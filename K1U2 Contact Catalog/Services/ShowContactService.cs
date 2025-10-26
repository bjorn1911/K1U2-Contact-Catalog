using K1U2_Contact_Catalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K1U2_Contact_Catalog.Menu;

namespace K1U2_Contact_Catalog.Services
{
    public static class ShowContactService
    {
        public static void ListContacts(Dictionary<int, Contact> contacts)
        {
            foreach (var kv in contacts)
            {
                Console.WriteLine($"|ID: [{kv.Key}] |Name: {kv.Value.GetName()} |Email: {kv.Value.GetEmail()}| {kv.Value.GetTagsAsString()}");
            }

            
        }

        public static void FindName(Dictionary<int, Contact> contacts, string name)
        {
            var results = contacts.Values.Where(c => c.GetName().Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("\nResults in Names");
            if (results.Count == 0)
            {
                Console.WriteLine("No contacts found with that name.");
            }
            else
            {
                //Console.WriteLine("Matching Names");
                ListContacts(results.ToDictionary(c => c.GetID(), c => c));
            }
            
        }

        public static void FindEmail(Dictionary<int, Contact> contacts, string email)
        {
            var results = contacts.Values.Where(c => c.GetEmail().Contains(email, StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("\nResults in Emails");
            if (results.Count == 0)
            {
                Console.WriteLine("No contacts found with that email.");
            }
            else
            {
                //Console.WriteLine("Matching Emails");
                ListContacts(results.ToDictionary(c => c.GetID(), c => c));
            }
        }

        public static void FindTag(Dictionary<int, Contact> contacts, string tag)
        {
            var results = contacts.Values.Where(c => c.GetTagsAsString().Contains(tag, StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("\nResults in Tags");
            if (results.Count == 0)
            {
                Console.WriteLine("No contacts found with that tag.");
            }
            else
            {
                //Console.WriteLine("Matching Tags");
                ListContacts(results.ToDictionary(c => c.GetID(), c => c));
            }
        }

        public static void ListContactsByTags(Dictionary<int, Contact> contacts)
        {
            var sortedContacts = contacts.Values
                .OrderBy(c => c.GetTagsAsString())
                .ThenBy(c => c.GetName())
                .ToList();
            Console.WriteLine("Contacts Sorted by Tags:");
            ListContacts(sortedContacts.ToDictionary(c => c.GetID(), c => c));
        }
    }
}
