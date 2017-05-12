using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystem
{
    class GarageLogic
    {
        #region Values
        // Size of garage.
        private const int parkingLots = 100;
        // Instance of garage = a new garage.
        Garage garage = new Garage();
        #endregion

        #region Methods
        /// <summary>
        /// Adds a vehicle to the garage.
        /// </summary>
        /// <param name="regNr">Registration number for the vehicle to park.</param>
        /// <returns>Parked vehicle object.</returns>
        public bool ParkVehicle(string regNr, string vehicleType)
        {
            bool result = false;

            // If registration number is empty or not 6 characters
            if(regNr.Length != 6 || regNr.Length == 0)
                return result;

            vehicleType = vehicleType.ToLower();

            switch(vehicleType)
            {
                case "car":
                    Car car = new Car();
                    car.RegNumber = regNr;
                    if(car != null && garage.Veichles.Count < parkingLots)
                    {
                        garage.ParkVehicle(car);
                        result = true;
                    }
                    break;
                case "mc":
                    Motorcycle mc = new Motorcycle();
                    mc.RegNumber = regNr;
                    if(mc != null && garage.Veichles.Count < parkingLots)
                    {
                        garage.ParkVehicle(mc);
                        result = true;
                    }
                    break;
                case "bus":
                    Bus bus = new Bus();
                    bus.RegNumber = regNr;
                    if(bus != null && garage.Veichles.Count < parkingLots)
                    {
                        garage.ParkVehicle(bus);
                        result = true;
                    }
                    break;
                case "truck":
                    Truck truck = new Truck();
                    truck.RegNumber = regNr;
                    if(truck != null && garage.Veichles.Count < parkingLots)
                    {
                        garage.ParkVehicle(truck);
                        result = true;
                    }
                    break;
                default:
                    result = false;
                    break;
            }

            return result;
        }

        /// <summary>
        /// Remove a vehicle from the garage.
        /// </summary>
        /// <param name="regNr">Registration number for the vehicle to unpark.</param>
        /// <returns>Unparked vehicle object.</returns>
        protected internal bool UnParkVehicle(string regNr)
        {
            bool result = false;
            Vehicle vehicle = garage.Veichles.FirstOrDefault(v => v.RegNumber == regNr);

            if(vehicle != null)
            {
                garage.Veichles.Remove(vehicle);
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Find a vehicle with a given registration number.
        /// </summary>
        /// <param name="regNr">Registration number for the vehicle to lookup.</param>
        /// <returns>Vehicle object if found, null if no match.</returns>
        public Vehicle FindVehicleByRegNr(string regNr)
        {
            Vehicle vehicle = garage.Veichles.FirstOrDefault(v => v.RegNumber == regNr);

            return vehicle;
        }

        /// <summary>
        /// Find multiple vehicles matching given type.
        /// </summary>
        /// <param name="type">Type of vehicle.</param>
        /// <returns>List of vehicles found, null if no match.</returns>
        public List<Vehicle> FindMultipleVehiclesByType(string type)
        {
            List<Vehicle> vehicles = (from v in garage.Veichles
                                      where v.GetObjectType() == type
                                      select v).ToList();

            return vehicles;
        }

        /// <summary>
        /// Find multiple vehicles parked a given date.
        /// </summary>
        /// <param name="parkedDate">Date parked to search for.</param>
        /// <returns>List of vehicles found, null if no match.</returns>
        public List<Vehicle> FindMultipleVehiclesByDate(string parkedDate)
        {
            List<Vehicle> vehicles = (from v in garage.Veichles
                                     where v.ParkingDate.ToString() == parkedDate
                                     select v).ToList();

            return vehicles;
        }

        /// <summary>
        /// Get info about a specific vehicle.
        /// </summary>
        /// <param name="regNr">Registration number for the vehicle to lookup.</param>
        /// <returns>String of vehicle info.</returns>
        public string GetVehicleInfo(string regNr)
        {
            Vehicle vehicle = garage.Veichles.FirstOrDefault(v => v.RegNumber == regNr);

            TimeSpan tspan = DateTime.Now - vehicle.ParkingDate;
            decimal currentBill = tspan.Minutes * vehicle.ParkingPrice;

            return string.Format("{0,-10}{1,-10}{2,10}", vehicle.RegNumber, vehicle.ParkingDate, currentBill);
        }

        /// <summary>
        /// Get info of all vehicles in the garage.
        /// </summary>
        /// <returns>List of formatted strings with vehicle info.</returns>
        public List<string> GetGarageInfo()
        {
            List<string> vehicles = new List<string>();

            foreach(Vehicle v in garage.Veichles)
            {
                vehicles.Add(string.Format("{0,-10}{1,-10}", v.RegNumber, v.ParkingDate));
            }

            return vehicles;
        }

        /// <summary>
        /// Get info about number of occupied lots in the garage.
        /// </summary>
        /// <returns>Formatted string with lot statistics.</returns>
        public string GetLotStats()
        {
            return string.Format("Occupied lots: {0}/{1}: ", parkingLots, garage.Veichles.Count);
        }
        #endregion
    }
}