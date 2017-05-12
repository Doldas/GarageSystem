using System;

namespace GarageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            GarageLogic garage = new GarageLogic();
            bool showMainMenu = true;
            // Main menu
            while(true)
            {
                Console.Clear();
                Menu.ShowMenu();
                Console.Write("Value $: ");
                int choice = Menu.GetMainMenuChoice();
                // Show sub menu unless false
                bool showSubMenu = true;

                switch (choice)
                {
                    case 1:
                        // List sub menu
                        do
                        {
                            Console.Clear();
                            Menu.ShowParkMenu();
                            Console.Write("$: ");
                            choice = Menu.GetListMenuChoice();

                            switch (choice)
                            {
                                case 1:
                                    
                                    break;
                                case 2:
                                    
                                    break;
                                case 3:
                                   
                                    Console.WriteLine("Error code #9223");
                                    Console.WriteLine("Error code description:");
                                    Console.WriteLine("This is to enivormently-friendly.");
                                    Console.WriteLine("And we don´t want horse shit in the garage.");
                                    Console.ReadKey();
                                    break;
                                case 0:
                                    Console.Clear();
                                    showSubMenu = false;
                                    break;
                                default:
                                    break;
                            }
                        } while (showSubMenu != false);
                        break; // List sub menu end
                    case 2:
                        // Search sub menu
                        do
                        {
                            Menu.ShowUnparkMenu();
                            Console.Write("$: ");
                            choice = Menu.GetSearchMenuChoice();

                            switch (choice)
                            {
                                case 1:
                                    
                                    break;
                                case 2:
                                    
                                    break;
                                case 0:
                                    Console.Clear();
                                    showSubMenu = false;
                                    break;
                                default:
                                    break;
                            }
                        } while (showSubMenu != false);
                        break; // Search sub menu end
                    case 3:
                        do
                        {
                            Menu.ShowAdminMenu();
                            Console.Write("$: ");
                            choice = Menu.GetSearchMenuChoice();

                            switch (choice)
                            {
                                case 1:

                                    break;
                                case 2:

                                    break;
                                case 3:

                                    break;
                                case 4:

                                    break;
                                case 5:

                                    break;
                                case 0:
                                    Console.Clear();
                                    showSubMenu = false;
                                    break;
                                default:
                                    break;
                            }
                        } while (showSubMenu != false);
                        break;
                    case 0:
                        Console.WriteLine("Press any key to exit application.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
