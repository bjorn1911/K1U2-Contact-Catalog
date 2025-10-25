using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K1U2_Contact_Catalog.Menu;

namespace K1U2_Contact_Catalog.Services
{
    public class CatalogService
    {
        public CatalogService(bool running)
        {
            while (running)
            {
                Menu.Menu.MainMenu();
                var _input = Console.ReadLine();
                switch (_input)
                {
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
