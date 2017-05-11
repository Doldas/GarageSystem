using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystem
{
    class Garage
    {
        
        private List<Vehicle> smallVehicles = new List<Vehicle>();
        private List<Vehicle> largeVehicles = new List<Vehicle>();

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
        protected internal Vehicle ParkSmallVehicle(Vehicle vehicle)
        {
            if(vehicle != null)
                smallVehicles.Add(vehicle);

            return vehicle;
        }

        protected internal void ParkLargeVehicle(Vehicle vehicle)
        {
            largeVehicles.Add(vehicle);
        }

        protected internal void UnParkSmallVehicle(Vehicle vehicle)
        {
            smallVehicles.Remove(vehicle);
        }

        protected internal void UnParkLargeVehicle(Vehicle vehicle)
        {
            largeVehicles.Remove(vehicle);
        }

        protected internal void GetVehicleInfo()
        {

        }

        protected internal void GetAllVehicleInfo()
        {

        }

        protected internal void FindSingleVehicle()
        {

        }

        protected internal void FindMultipleVehicle
        {

        }
        #endregion
    }
}
