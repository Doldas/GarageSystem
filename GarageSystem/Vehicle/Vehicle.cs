using System;

namespace GarageSystem
{
    class Vehicle : IEquatable<Vehicle>
    {
        public string regNumber { set; get; } //This value should always be unique

        public string GetObjectType() //Returns the object type so that we can get what type the Vehicle is
        {
            return this.GetType().ToString();
        }
        //Check if a vehicle is the same as another vehicle (Useful for checking if same vehicle already exists)
        bool IEquatable<Vehicle>.Equals(Vehicle other)
        {
            return this.regNumber == other.regNumber;
        }
        override bool IEquatable<Vehicle>.Equals(object other) //Takes in an object for checking if it's same as this instance
        {
            return other.GetType() == this.GetType();
        }
    }
}
