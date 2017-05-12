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
                Menu.ShowMenu();
                Console.Write("$: ");
                int choice = Menu.GetMainMenuChoice();
                Console.WriteLine();
                // Show sub menu unless false
                bool showSubMenu = true;
                string regNr;

                switch(choice)
                {
                    case 1:
                        // Show Park menu
                        do
                        {
                            Menu.ShowParkMenu();
                            Console.Write("$: ");
                            choice = Menu.GetParkMenuChoice();

                            switch(choice)
                            {
                                case 1:
                                    Console.WriteLine("You are parking a motorcycle!");
                                    Console.Write("Please type registration number: ");
                                    regNr = Console.ReadLine();

                                    if (!garage.ParkVehicle(regNr, "mc"))
                                        Console.WriteLine("Vehicle was not parked.");
                                    else
                                        Console.WriteLine("Your motorcycle with registration {0} is now parked.", regNr);
                                    
                                    // Debug
                                    //foreach (string v in garage.GetGarageInfo())
                                    //    Console.WriteLine(v);
                                    //Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("You are parking a car!");
                                    Console.Write("Please type registration number: ");
                                    regNr = Console.ReadLine();
                                   
                                    if (!garage.ParkVehicle(regNr, "car"))
                                        Console.WriteLine("{0} was not parked.", regNr);
                                    else
                                        Console.WriteLine("Your car with registration {0} is now parked.", regNr);
                                    Console.WriteLine();
                                    break;
                                case 3:
                                    Console.WriteLine("You are parking a bus!");
                                    Console.Write("Please type registration number: ");
                                    regNr = Console.ReadLine();

                                    if (!garage.ParkVehicle(regNr, "bus"))
                                        Console.WriteLine("{0} was not parked.", regNr);
                                    else
                                        Console.WriteLine("Your bus with registration {0} is now parked.", regNr);
                                    Console.WriteLine(garage.GetVehicleInfo(regNr));
                                    break;
                                case 4:
                                    Console.WriteLine("You are parking a truck!");
                                    Console.Write("Please type registration number: ");
                                    regNr = Console.ReadLine();

                                    if (!garage.ParkVehicle(regNr, "truck"))
                                        Console.WriteLine("{0} was not parked.", regNr);
                                    else
                                        Console.WriteLine("Your truck with registration {0} is now parked.", regNr);

                                    break;
                                case 5:
                                    Console.WriteLine("Error code #9223");
                                    Console.WriteLine("Error code description:");
                                    Console.WriteLine("This is to enivormently-friendly.");
                                    Console.WriteLine("And we don´t want horse shit in the garage.");
                                    Console.ReadKey();
                                    break;
                                case 0:
                                    showSubMenu = false;
                                    break;
                                default:
                                    break;
                            }
                        } while (showSubMenu != false);
                        break; // List park menu end
                    case 2:
                        Console.WriteLine("Unpark vehicle.");
                        Console.Write("Please type registration number: ");
                        regNr = Console.ReadLine();
                        Console.WriteLine();
                        break; 
                    case 3:
                        do
                        {
                            Menu.ShowAdminMenu();
                            Console.Write("$: ");
                            choice = Menu.GetSearchMenuChoice();

                            switch(choice)
                            {
                                case 1:
                                    //See basic information for all vehicles

                                    foreach (string v in garage.GetGarageInfo())
                                    {
                                        Console.WriteLine(v);
                                    }
                                    Console.WriteLine();

                                    break;
                                case 2:
                                    //See Information about specefic vehicle
                                    Console.WriteLine("Search vehicle.");
                                    Console.Write("Please type registration number: ");
                                    regNr = Console.ReadLine();
                                    Console.WriteLine(garage.GetVehicleInfo(regNr));
                                    Console.WriteLine();
                                    break;
                                case 3:
                                    //Search for specific vehicle
                                    Console.WriteLine("You want to search after a vehicle.");
                                    Console.Write("Please type registration number: ");
                                    regNr = Console.ReadLine();
                                    Console.WriteLine(garage.GetVehicleInfo(regNr));
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    //Search for vehicle by type 
                                    Console.WriteLine("Search vehicle by type 'car', 'mc', 'bus' or 'truck'");
                                    Console.Write("Please enter type: ");
                                    string type = Console.ReadLine();

                                    foreach (Vehicle v in garage.FindMultipleVehiclesByType(type))
                                    {
                                        Console.WriteLine(v);
                                    }
                                    Console.WriteLine();
                                    break;
                                case 5:
                                    // Search for vehicle by date parked
                                    Console.WriteLine("You want to search after a vehicle by date.");
                                    Console.Write("Please type a date: ");
                                    string parkedDate = Console.ReadLine();

                                    foreach(Vehicle v in garage.FindMultipleVehiclesByDate(parkedDate))
                                    {
                                        Console.WriteLine(v);
                                    }
                                    Console.WriteLine();
                                    break;
                                case 0:
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
