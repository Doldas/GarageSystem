using System;

namespace GarageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            GarageLogic garage = new GarageLogic();

            garage.ParkVehicle("123abc", "car");
            garage.ParkVehicle("456def", "mc");
            garage.ParkVehicle("321cba", "truck");
            garage.ParkVehicle("654fed", "bus");
            
    


            bool showMainMenu = true;
            // Main menu
            do
            {
                Console.Clear();
                Menu.ShowMenu();
                Console.Write("Value $: ");
                int choice = Menu.GetMainMenuChoice();
                // Show sub menu unless false
                bool showSubMenu = true;

                switch(choice)
                {
                    case 1:
                        // Show Park menu
                        do
                        {
                            Console.Clear();
                            Menu.ShowParkMenu();
                            Console.Write("$: ");
                            choice = Menu.GetListMenuChoice();

                            switch(choice)
                            {
                                case 1:
                                    Console.WriteLine("You are parking a motorcycle!/n");
                                    Console.WriteLine("Please type Regestration number?/n");
                                    string regNr = Console.ReadLine();
                                    garage.ParkVehicle(regNr, "mc");

                                    if (mc != null)
                                    {
                                        Console.WriteLine("Your motorcycle is now parked.");
                                    }
                                    
                                    break;
                                case 2:
                                    Console.WriteLine("You are parking a car!/n");
                                    Console.WriteLine("Please type Regestration number?/n");
                                    regNr = Console.ReadLine();
                                    garage.ParkVehicle(regNr, "car");

                                    if (car != null)
                                    {
                                        Console.WriteLine("Your car is now parked.");
                                    }
                                    
                                    break;
                                case 3:
                                    Console.WriteLine("You are parking a bus!/n");
                                    Console.WriteLine("Please type Regestration number?/n");
                                    regNr = Console.ReadLine();
                                    garage.ParkVehicle(regNr, "bus");
                                   
                                    if (car != null)
                                    {
                                        Console.WriteLine("Your bus is now parked.");
                                    }

                                    break;
                                case 4:
                                    Console.WriteLine("You are parking a truck!/n");
                                    Console.WriteLine("Please type Regestration number?/n");
                                    regNr = Console.ReadLine();
                                    garage.ParkVehicle(regNr, "Truck");

                                    if (car != null)
                                    {
                                        Console.WriteLine("Your truck is now parked.");
                                    }

                                    break;
                                case 5:
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
                        break; // List park menu end
                    case 2:
                        // Show unpark menu
                        /*do
                        {
                            Menu.ShowUnparkMenu();
                            Console.Write("$: ");
                            choice = Menu.GetSearchMenuChoice();

                            switch(choice)
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
                        } while (showSubMenu != false);*/
                        break; // Search unpark menu end
                    case 3:
                        do
                        {
                            Menu.ShowAdminMenu();
                            Console.Write("$: ");
                            choice = Menu.GetSearchMenuChoice();

                            switch(choice)
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
                        } while(showSubMenu != false);
                        break;
                    case 0:
                        Console.WriteLine("Press any key to exit application.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while(showMainMenu != false);
        }
    }
}
