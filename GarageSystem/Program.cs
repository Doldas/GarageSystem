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
                string regNr;

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
                                    Console.WriteLine("You are parking a motorcycle!");
                                    Console.Write("Please type Regestration number: ");
                                    regNr = Console.ReadLine();

                                    if (!garage.ParkVehicle(regNr, "mc"))
                                        Console.WriteLine("Vehicle was not parked.");
                                    else
                                        Console.WriteLine("Your motorcycle with registration {0} is now parked.", regNr);
                                    
                                    // Debug
                                    foreach (string v in garage.GetGarageInfo())
                                        Console.WriteLine(v);
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("You are parking a car!/n");
                                    Console.WriteLine("Please type Regestration number?/n");
                                    regNr = Console.ReadLine();
                                    garage.ParkVehicle(regNr, "car");

                                    if (!garage.ParkVehicle(regNr, "car"))
                                        Console.WriteLine("{0} was not parked.", regNr);
                                    else
                                        Console.WriteLine("Your motorcycle with registration {0} is now parked.", regNr);
                                    
                                    break;
                                case 3:
                                    Console.WriteLine("You are parking a bus!/n");
                                    Console.WriteLine("Please type Regestration number?/n");
                                    regNr = Console.ReadLine();
                                    garage.ParkVehicle(regNr, "bus");
                                   
                                    break;
                                case 4:
                                    Console.WriteLine("You are parking a truck!/n");
                                    Console.WriteLine("Please type Regestration number?/n");
                                    regNr = Console.ReadLine();
                                    garage.ParkVehicle(regNr, "Truck");

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
                        Console.WriteLine("You want to unpark a vehicle/n");
                        Console.WriteLine("Please type regestration number?/n");
                        regNr = Console.ReadLine();
                        Console.WriteLine(garage.GetVehicleInfo(regNr));
                        Console.ReadKey();
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
                                    //See basic information for all vehicles
                                    foreach (string v in garage.GetGarageInfo())
                                    {
                                        Console.WriteLine(v);
                                    }
                                    break;
                                case 2:
                                    //See Information about specefic vehicle
                                    break;
                                case 3:
                                    //Search for specific vehicle
                                    Console.WriteLine("You want to serch after a vehicle /n");
                                    Console.WriteLine("Please type regestration number?/n");
                                    regNr = Console.ReadLine();
                                    
                                    //Testing - Change this
                                    Console.WriteLine(garage.FindVehicleByRegNr(regNr).GetObjectType()); //Get the vehicle type
                                    Console.ReadKey();
                                    //foreach (Book.Book b in GarageLogic.())
                                    //{
                                    //    Console.WriteLine(b.Title);

                                    //}
                                    break;
                                case 4:
                                    //Search for vehicle by type 
                                    //Search for specific vehicle
                                    Console.WriteLine("You want to serch after a vehicles /n");
                                    Console.WriteLine("Please type in the vehicle type (Car,Motorcycle...)?/n");
                                    regNr = Console.ReadLine();

                                    //Testing - Change this
                                    foreach (Vehicle v in garage.FindMultipleVehiclesByType(regNr))
                                    {
                                        Console.WriteLine(garage.GetVehicleInfo(v.RegNumber)+"\n");
                                    }
                                    
                                    Console.ReadKey();

                                    break;
                                case 5:
                                    // Search for vehicle by date parked
 
                                    Console.WriteLine("You want to unpark a vehicle/n");
                                    Console.WriteLine("Please type in the date?/n");
                                    regNr = Console.ReadLine();
                                   
                                    foreach (Vehicle v in garage.FindMultipleVehiclesByDate(regNr))
                                    {
                                        Console.WriteLine(garage.GetVehicleInfo(v.RegNumber) + "\n");
                                    }
                                    Console.ReadKey();
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
