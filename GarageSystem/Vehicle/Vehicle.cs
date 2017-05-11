using System;

namespace GarageSystem
{
    class Vehicle
    {
        public string RegNumber { set; get; } //This value should always be unique
        public DateTime DateTime { set; get; }
        public decimal Price { get; set; }

        public string GetObjectType() //Returns the object type so that we can get what type the Vehicle is
        {
            return this.GetType().ToString();
        }

        public bool Equals(Vehicle other)
        {
            if (other == null) return false;
            if (this.RegNumber == other.RegNumber) return true;
            else return false;
        }
        /// <summary>
        /// Overriden from object, see previous method
        /// </summary>
        /// <param name="obj">object to compare to</param>
        /// <returns>If the other object equals this object</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Vehicle vehicleObject = obj as Vehicle;
            if (vehicleObject == null) return false;
            else return Equals(vehicleObject);
        }
    }
}
