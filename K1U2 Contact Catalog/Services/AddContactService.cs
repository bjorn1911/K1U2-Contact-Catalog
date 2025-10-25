using K1U2_Contact_Catalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace K1U2_Contact_Catalog.Services
{
    internal class AddContactService : Interfaces.IAddContactService
    {
        public Contact AddContact(int ID, HashSet<string> EmailIndex)
        {
            var contact = new Contact(ID);

            Menu.Menu.PrintHeader("add contact #" + ID);
            Console.Write("Please Enter Email:");
            string _email = Console.ReadLine();

            if (!ValidationService.IsValidEmail(_email)) throw new InvalidEmailException(_email);
            if (!EmailIndex.Add(_email)) throw new DuplicateEmailException(_email);
            
            return contact;

        }
    }
}
