using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystem
{
    class GarageLogic
    {
        private const int parkingLots = 100;
        Garage garage = new Garage();

        public Vehicle ParkVehicle(string regNr, DateTime dateTime)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.RegNumber = regNr;
            vehicle.ParkingDate = dateTime;

            // Check that the vehicle object contains data and run the proper
            // function
            if(vehicle != null && garage.Veichles.Count < parkingLots)
            {
                garage.ParkVehicle(vehicle);
                return vehicle;
            }

            return vehicle;
        }

        public Vehicle UnParkVehicle(string regNr)
        {
            Vehicle vehicle = garage.Veichles.FirstOrDefault(v => v.RegNumber == regNr);

            if(vehicle != null)
            {
                garage.Veichles.Remove(vehicle);
                return vehicle;
            }

            return vehicle;
        }

        public Vehicle FindVehicleByRegNr(string regNr)
        {
            Vehicle vehicle = garage.Veichles.FirstOrDefault(v => v.RegNumber == regNr);

            return vehicle;
        }

        public List<Vehicle> FindMultipleVehiclesByType(string type)
        {
            List<Vehicle> vehicles = (from v in garage.Veichles
                                      where v.GetObjectType() == type
                                      select v).ToList();

            return vehicles;
        }

        public List<Vehicle> FindMultipleVehiclesByDate(string parkedDate)
        {
            List<Vehicle> vehicles = (from v in garage.Veichles
                                     where v.ParkingDate.ToString() == parkedDate
                                     select v).ToList();

            return vehicles;
        }

        public string GetVehicleInfo(string regNr)
        {
            Vehicle vehicle = garage.Veichles.FirstOrDefault(v => v.RegNumber == regNr);

            TimeSpan tspan = DateTime.Now - vehicle.ParkingDate;
            decimal currentBill = tspan.Minutes * vehicle.ParkingPrice;

            return string.Format("{0,-10}{1,-10}{2,10}", vehicle.RegNumber, vehicle.ParkingDate, currentBill);
        }
    }
}