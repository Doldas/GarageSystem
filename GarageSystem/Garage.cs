using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystem
{
    class Garage
    {
        private const int smallParkingLots = 100;
        private const int largeParkingLots = 20;
        List<Vehicle> smallVehicles = new List<Vehicle>();
        List<Vehicle> largeVehicles = new List<Vehicle>();

        #region Properties
        public List<Vehicle> SmallVehicles
        {
            get { return smallVehicles; }
            private set { }
        }

        public List<Vehicle> LargeVehicles
        {
            get { return largeVehicles; }
            private set { }
        }
        #endregion

        #region Method
        static void ParkSmallVehicle()
        {

        }

        static void ParkLargeVehicle()
        {

        }

        static void UnParkSmallVehicle()
        {

        }

        static void UnParkLargeVehicle()
        {

        }

        static void GetVehicleInfo()
        {

        }

        static void GetAllVehicleInfo()
        {

        }

        static void FindSingleVehicle()
        {

        }

        static void FindMultipleVehicle
        {

        }
        #endregion
    }
}
