using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystem
{
    class Garage
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        #region Properties
        public List<Vehicle> Veichles
        {
            get { return vehicles; }
            private set { }
        }
        #endregion
         
        #region Methods
        protected internal void ParkVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        protected internal void UnParkVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }
        #endregion
    }
}
