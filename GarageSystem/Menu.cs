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
        /// List items unpark menu.
        /// </summary>
       /* internal static void ShowUnparkMenu()
        {
            Console.WriteLine("### Unpark vehicle ###");
            Console.WriteLine("1) Unpark small vehicle");
            //Console.WriteLine("2) Unpark large vehicle");
            Console.WriteLine("0) Back to Main");
        }*/
        /// <summary>
        /// Search item in admin  menu.
        /// </summary>
        internal static void ShowAdminMenu()
        {
            Console.WriteLine("### Admin menu and search ###");
            Console.WriteLine("1) See basic information for all vehicles");
            Console.WriteLine("2) See Information about specefic vehicle");
            Console.WriteLine("3) Search for specific vehicle");
            Console.WriteLine("4) Search for vehicle by type   ");
            Console.WriteLine("5) Search for vehicle by date parked");
            Console.WriteLine("0) Back to Main");
        }

        /// <summary>
        /// Handle user input for Main menu.
        /// </summary>
        /// <returns></returns>
        internal static int GetMainMenuChoice()
        {
            string input = Console.ReadLine();
            int choice=-1;
            try
            {
                choice = int.Parse(input);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter a valid choice.\nPress a key to continue");
                Console.ReadKey();
            }
            /* Returns 0 if false - 0=Exit = Problem
            if (!int.TryParse(input, out choice) && choice < 0 || choice > 4)
            {
                Console.WriteLine("Please enter a valid choice.\n");
            }
             * */
            return choice;
        }

        /// <summary>
        /// Handle user input for List items submenu.
        /// </summary>
        /// <returns></returns>
        internal static int GetListMenuChoice()
        {
            string input = Console.ReadLine();
            int choice;

            if (!int.TryParse(input, out choice) && choice < 0 || choice > 5)
            {
                Console.WriteLine("Please enter a valid choice.\n");
            }
            return choice;
        }

        /// <summary>
        /// Handle user input for Search menu.
        /// </summary>
        /// <returns></returns>
        internal static int GetSearchMenuChoice()
        {
            string input = Console.ReadLine();
            int choice;

            if (!int.TryParse(input, out choice) && choice < 0 || choice > 5)
            {
                Console.WriteLine("Please enter a valid choice.\n");
            }
            return choice;
        }

        /// <summary>
        /// Print product header.
        /// </summary>
       /* internal static void PrintHeader()
        {
            Console.WriteLine(string.Format("{0,-6}{1,-20}{2,-12}{3,-13}{4,-10}",
                                            "Part#", "Name", "Category", "Price", "Amount"));
            Console.WriteLine("---------------------------------------------------------");
        }*/
    }
}
