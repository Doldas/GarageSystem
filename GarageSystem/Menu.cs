using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystem
{
    public static class Menu
    {
        /// <summary>
        /// Main menu.
        /// </summary>
        internal static void ShowMenu()
        {
            Console.WriteLine("### Welcome to the parking space ###");
            Console.WriteLine("1) Park vehicle");
            Console.WriteLine("2) Unpark vehicle");
            Console.WriteLine("3) View admin");
            Console.WriteLine("0) Exit");
        }


        /// <summary>
        /// List items park menu.
        /// </summary>
        internal static void ShowParkMenu()
        {
            Console.WriteLine("### Park vehicle ###");
            Console.WriteLine("1) Park a motorcycle");
            Console.WriteLine("2) Park a car");
            Console.WriteLine("3) Park a bus");
            Console.WriteLine("4) Park a truck");
            Console.WriteLine("5) Park a horse-and-buggy ");
            Console.WriteLine("0) Back to Main");
        }

        /// <summary>
        /// Search item in admin  menu.
        /// </summary>
        internal static void ShowAdminMenu()
        {
            Console.WriteLine("### Admin menu and search ###");
            Console.WriteLine("1) See basic information for all vehicles");
            Console.WriteLine("2) See Information about specefic vehicle");
            Console.WriteLine("3) Search for specific vehicle");
            Console.WriteLine("4) Search for vehicles by type   ");
            Console.WriteLine("5) Search for vehicles by date parked");
            Console.WriteLine("0) Back to Main");
        }

        /// <summary>
        /// Handle user input for Main menu.
        /// </summary>
        /// <returns></returns>
        internal static int GetMainMenuChoice()
        {
            string input = Console.ReadLine();
            int choice = -1;
            try
            {
                choice = int.Parse(input);
            }
            catch
            {
                Console.WriteLine("Please enter a valid choice.");
            }
            return choice;
        }

        /// <summary>
        /// Handle user input for List items submenu.
        /// </summary>
        /// <returns></returns>
        internal static int GetListMenuChoice()
        {
            string input = Console.ReadLine();
            int choice = -1;
            try
            {
                choice = int.Parse(input);
            }
            catch
            {
                Console.WriteLine("Please enter a valid choice.");
            }

            return choice;
        }

        /// <summary>
        /// Handle user input for Search menu.
        /// </summary>
        /// <returns></returns>
        internal static int GetAdminMenuChoice()
        {
            string input = Console.ReadLine();
            int choice = -1;
            try
            {
                choice = int.Parse(input);
            }
            catch
            {
                Console.WriteLine("Please enter a valid choice.");
            }

            return choice;
        }

        /// <summary>
        /// Display the park menu.
        /// </summary>
        /// <returns></returns>
        internal static int GetParkMenuChoice()
        {
            string input = Console.ReadLine();
            int choice = -1;

            {
                try
                {
                    choice = int.Parse(input);

                    if(choice < 0 || choice > 5)
                        Console.WriteLine("Please enter a valid choice.");
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Please enter a valid choice.");
                    Console.WriteLine();
                }
            }

            return choice;
        }
        
        /// <summary>
        /// Print header with labels.
        /// </summary>
        internal static void PrintHeader()
        {
            Console.WriteLine(string.Format("{0,-10}{1,-10}{2,10}", "Type", "Reg #", "Parked Date"));
            Console.WriteLine("---------------------------------------");
        }
    }
}
