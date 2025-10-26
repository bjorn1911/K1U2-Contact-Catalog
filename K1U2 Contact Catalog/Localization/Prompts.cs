using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2_Contact_Catalog.Menu
{
    static class Prompts
    {
        public static void MainMenu()
        {

            PrintHeader("CONTACT-O-TRON 2000");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Find Contact");
            Console.WriteLine("3. Export Contacts");
            Console.WriteLine("4. List all Contacts Alphabetically");
            Console.WriteLine("0. Exit");

            Console.WriteLine(""); // Create a space before input

            Console.Write("Select an option: ");

        }

        public static string AskForName()
        {
            return "Please enter the name: ";
        }
        public static string AskForEmail()
        {
            return "Please enter Email Address: ";
        }

        public static string AskForTags()
        {
            return "Please enter tags (separate each tag with a comma): ";
        }

        public static void FindContact()
        {
            PrintHeader("Find Contacts");
            Console.Write("Search for: ");
        }


        static void ExportContact()
        {
            PrintHeader("export contacts");
        }



        public static void PrintHeader(string header) // Just a smalll method to make menu headers easily.
        {
            Console.Clear();
            Console.WriteLine("K1U2 Contact Catalog - by Björn Blomberg - NETX25\n");
            header = header.ToUpper();
            //Console.WriteLine("\n");
            for (int i = 0; i < header.Length + 6; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine($"\n** {header} **");
            for (int i = 0; i < header.Length + 6; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n");
        }

        public static void PressKeyToContinue()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
