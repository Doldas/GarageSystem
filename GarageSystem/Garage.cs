using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystem
{
    class Garage
    {
        #region Values
        private List<Vehicle> vehicles = new List<Vehicle>();
        #endregion

        #region Properties
        public List<Vehicle> Veichles
        {
            get { return vehicles; }
            private set { }
        }
        #endregion
         
        #region Methods
        /// <summary>
        /// Add a vehicle to the garage.
        /// </summary>
        /// <param name="vehicle">Vehicle object to add.</param>
        protected internal void ParkVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        /// <summary>
        /// Remove a vehicle from the garage.
        /// </summary>
        /// <param name="vehicle">Vehicle to unpark.</param>
        protected internal void UnParkVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }
        #endregion
    }
}
