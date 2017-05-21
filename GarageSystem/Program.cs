using System;

namespace GarageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            GarageLogic garage = new GarageLogic();

            garage.ParkVehicle("abc123", "car");
            garage.ParkVehicle("gtk765", "car");
            garage.ParkVehicle("def456", "mc");
            garage.ParkVehicle("qrt908", "mc");
            garage.ParkVehicle("cba321", "truck");
            garage.ParkVehicle("vgt104", "truck");
            garage.ParkVehicle("fed654", "bus");
            garage.ParkVehicle("klr887", "bus");

            bool showMainMenu = true;
            bool checkedIn = false;
            string rNSaved="";
            // Main menu
            do
            {
                Menu.ShowMenu(checkedIn);
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
                            if (checkedIn == false)
                            {
                                Menu.ShowParkMenu();
                                Console.Write("$: ");
                                choice = Menu.GetParkMenuChoice();

                                switch (choice)
                                {
                                    case 1:
                                        Console.WriteLine("You are parking a motorcycle!");
                                        Console.Write("Please type registration number: ");
                                        regNr = Console.ReadLine();
                                        rNSaved = regNr;
                                        if (!garage.ParkVehicle(regNr, "mc"))
                                            Console.WriteLine("Vehicle was not parked.");
                                        else
                                        {
                                            Console.WriteLine("Your motorcycle with registration {0} is now parked.", regNr);
                                            rNSaved = regNr;
                                            checkedIn = true;
                                        }
                                        Console.WriteLine();
                                        showSubMenu = false;
                                        break;
                                    case 2:
                                        Console.WriteLine("You are parking a car!");
                                        Console.Write("Please type registration number: ");
                                        regNr = Console.ReadLine();
                                        rNSaved = regNr;

                                        if (!garage.ParkVehicle(regNr, "car"))
                                            Console.WriteLine("{0} was not parked.", regNr);
                                        else
                                        {
                                            Console.WriteLine("Your car with registration {0} is now parked.", regNr);
                                            rNSaved = regNr;
                                            checkedIn = true;
                                        }
                                        Console.WriteLine();
                                        showSubMenu = false;
                                        break;
                                    case 3:
                                        Console.WriteLine("You are parking a bus!");
                                        Console.Write("Please type registration number: ");
                                        regNr = Console.ReadLine();
                                        if (!garage.ParkVehicle(regNr, "bus"))
                                            Console.WriteLine("{0} was not parked.", regNr);
                                        else
                                        {
                                            Console.WriteLine("Your bus with registration {0} is now parked.", regNr);
                                            rNSaved = regNr;
                                            checkedIn = true;
                                        }
                                        Console.WriteLine(garage.GetVehicleInfo(regNr));
                                        showSubMenu = false;
                                        break;
                                    case 4:
                                        Console.WriteLine("You are parking a truck!");
                                        Console.Write("Please type registration number: ");
                                        regNr = Console.ReadLine();

                                        if (!garage.ParkVehicle(regNr, "truck"))
                                            Console.WriteLine("{0} was not parked.", regNr);
                                        else
                                        {
                                            Console.WriteLine("Your truck with registration {0} is now parked.", regNr);
                                            rNSaved = regNr;
                                            checkedIn = true;
                                        }

                                        showSubMenu = false;
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
                            }
                            else if(checkedIn==true)
                            {
                                bool asking = true;
                                do
                                {
                                    Console.WriteLine("Do you want to check out?");
                                    Console.WriteLine("('1') Yes");
                                    Console.WriteLine("('2') No");
                                    switch (Console.ReadLine())
                                    {
                                        case "1":
                                            asking = false;
                                            checkedIn = false;
                                            Menu.PrintHeader();
                                            Console.WriteLine(garage.GetVehicleInfo(rNSaved));
                                            Console.WriteLine();
                                            garage.UnParkVehicle(rNSaved);
                                            Console.WriteLine("Have a nice day!");
                                            showSubMenu = false;
                                            break;
                                        case "2":
                                            asking = false;
                                            showSubMenu = false;
                                            break;
                                        default:
                                            Console.WriteLine("Please answer with either number 1 or number 2!");
                                            break;
                                    }
                                }
                                while (asking);
                            }
                        } while(showSubMenu != false);
                        break; // List park menu end
                    case 2:
                        Console.WriteLine("Unpark vehicle.");
                        Console.Write("Please type registration number: ");
                        regNr = Console.ReadLine();
                        Console.WriteLine();
                        
                        Menu.PrintHeader();
                        Console.WriteLine(garage.GetVehicleInfo(regNr));
                        Console.WriteLine();
                        if(garage.UnParkVehicle(regNr))
                        {
                            Console.WriteLine("Vehicle unparked");
                            Console.WriteLine();
                        }
                        else
                            Console.WriteLine("Not found.");
                        break;
                    case 3:
                        do
                        {
                            Menu.ShowAdminMenu();
                            Console.Write("$: ");
                            choice = Menu.GetAdminMenuChoice();
                            Console.WriteLine();

                            switch(choice)
                            {
                                case 1:
                                    //See basic information for all vehicles
                                    Menu.PrintHeader();
                                    foreach(string v in garage.GetGarageInfo())
                                    {
                                        Console.WriteLine(v);
                                    }
                                    Console.WriteLine();
                                    break;
                                case 2:
                                    //See Information about specefic vehicle
                                    Console.WriteLine("See information about specific vehicle.");
                                    Console.Write("Please type registration number: ");
                                    regNr = Console.ReadLine();
                                    Console.WriteLine();

                                    Menu.PrintHeader();
                                    Console.WriteLine(garage.GetVehicleInfo(regNr));
                                    Console.WriteLine();
                                    break;
                                case 3:
                                    //Search for specific vehicle
                                    Console.WriteLine("Search specific vehicle.");
                                    Console.Write("Please type registration number: ");
                                    regNr = Console.ReadLine();
                                    Console.WriteLine();
                                    
                                    Menu.PrintHeader();
                                    Console.WriteLine(garage.GetVehicleInfo(regNr));
                                    Console.WriteLine();
                                    break;
                                case 4:
                                    //Search for vehicle by type 
                                    Console.WriteLine("Search vehicle by type 'car', 'mc', 'bus' or 'truck'");
                                    Console.Write("Please enter type: ");
                                    string type = Console.ReadLine();
                                    Console.WriteLine();

                                    Menu.PrintHeader();
                                    foreach(Vehicle v in garage.FindMultipleVehiclesByType(type))
                                    {
                                        Console.WriteLine(v);
                                    }
                                    Console.WriteLine();
                                    break;
                                case 5:
                                    // Search for vehicle by date parked
                                    Console.WriteLine("Search for vehicle by numerical day parked (Ex. 12)");
                                    Console.Write("Please enter day: ");
                                    string parkedDate = Console.ReadLine();
                                    Console.WriteLine();

                                    Menu.PrintHeader();
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
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while(showMainMenu != false);
        }
    }
}
