using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystem
{
    class GarageLogic
    {
        private const int smallParkingLots = 100;
        private const int largeParkingLots = 20;
        Garage garage = new Garage();

        public void ParkVehicle(string regNr, DateTime dateTime, bool small)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.RegNumber = regNr;
            vehicle.DateTime = dateTime;

            // Check that the vehicle object contains data and run the proper
            // function
            if(small == true && vehicle != null)
                garage.ParkSmallVehicle(vehicle);
            if(small == false && vehicle != null)
                garage.ParkLargeVehicle(vehicle);
        }
    }
}