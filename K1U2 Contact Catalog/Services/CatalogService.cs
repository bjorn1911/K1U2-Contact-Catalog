using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K1U2_Contact_Catalog.Menu;
using K1U2_Contact_Catalog.Models;
using K1U2_Contact_Catalog.Interfaces;
using System.Security.Cryptography.X509Certificates;



namespace K1U2_Contact_Catalog.Services
{
    public class CatalogService
    {
        private int _nextID = 1;
        private IAddContactService _addContact;

        public CatalogService(bool running)
        {
            var contacts = new Dictionary<int, Contact>();
            var emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            while (true)
            {
                Menu.Menu.MainMenu();
                var _input = Console.ReadLine();
                switch (_input)
                {
                    case "1":
                        contacts.Add(_nextID, _addContact.AddContact(_nextID++, emails));
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Menu.Menu.PressKeyToContinue();
                        break;
                }
            }
        }
    }
}
