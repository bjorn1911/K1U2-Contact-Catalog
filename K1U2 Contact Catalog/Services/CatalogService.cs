using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K1U2_Contact_Catalog.Menu;
using K1U2_Contact_Catalog.Models;
using System.Security.Cryptography.X509Certificates;
using System.Net.Quic;
using System.Linq.Expressions;



namespace K1U2_Contact_Catalog.Services
{
    public class CatalogService
    {
        private int _nextID = 1;
        
        Dictionary<int, Contact> contacts = new ();
        HashSet<string> emails = new(StringComparer.OrdinalIgnoreCase);

        public CatalogService(bool running)
        {
            while (running) // Keep the menu running until user decides to exit
            {
                Prompts.MainMenu(); // I want to keep an abundance of strings out of the main code, so I made a separate class for that.
                var _input = Console.ReadLine();
                switch (_input)
                {
                    case "1":
                        
                        Contact newContact = new(_nextID); // Temporary storage for contact info
                        
                        // This section takes care of asking for info
                        Console.Write(Prompts.AskForName()); 
                        newContact.SetName(Console.ReadLine());
                        Console.Write(Prompts.AskForEmail());
                        string emailInput = Console.ReadLine();
                        
                        try
                        {
                            // I skipped making custom exceptions - I know how to do that though but it seemed unnecessary here.
                            if (!ValidationService.IsValidEmail(emailInput)) { throw new Exception("Invalid Email Format"); }
                            if (!emails.Add(emailInput)) { throw new Exception("Duplicate Email Detected"); }
                        }
                        catch (Exception ex) 
                        {
                            Console.WriteLine($"Fel: {ex.Message}");
                            Prompts.PressKeyToContinue();
                            break;
                        }
                        
                        newContact.SetEmail(emailInput);
                        
                        Console.Write(Prompts.AskForTags());
                        // Take input string of tags separated by , and add to Contact Tag list
                        string input = Console.ReadLine();
                        string[] _tags = input.Split(",");

                        for (int i = 0; i < _tags.Length; i++)
                        {
                            _tags[i] = _tags[i].Trim();
                            newContact.AddTag(_tags[i]);
                        }

                        contacts.Add(newContact.GetID(), newContact); // Only add contact if email is unique
                        Console.WriteLine($"[{newContact.GetID()}] {newContact.GetName()} ({newContact.GetEmail()}) added to Contact Catalog");
                        _nextID++;
                        Prompts.PressKeyToContinue();

                        break;
                    
                    case "2":
                        Prompts.FindContact();
                        string searchTerm = Console.ReadLine();
                        ShowContactService.FindName(contacts, searchTerm);
                        ShowContactService.FindEmail(contacts, searchTerm);
                        ShowContactService.FindTag(contacts, searchTerm);
                        Prompts.PressKeyToContinue();
                        break;

                    case "3":
                        ShowContactService.ListContactsByTags(contacts);
                        Prompts.PressKeyToContinue();
                        break;

                    case "4":
                        Prompts.PrintHeader("All Contacts");
                        ShowContactService.ListContacts(contacts);
                        Prompts.PressKeyToContinue();
                        break;

                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Prompts.PressKeyToContinue();
                        break;
                }
            }
        }
    }
}
