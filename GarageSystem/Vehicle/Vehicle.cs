using System;

namespace GarageSystem
{
    class Vehicle
    {
        public string RegNumber { set; get; } //This value should always be unique
        public decimal ParkingPrice { set; get; } //Price for parking
        public DateTime ParkingDate { set; get; } //Date variable for Parking
       
        public Vehicle()//Constructor
        {
            ParkingDate = DateTime.Now; //Setting the ParkingDate to the date on the system
        }
        public string GetObjectType() //Returns the object type so that we can get what type the Vehicle is
        {
            return this.GetType().ToString();
        }
        public bool Equals(Vehicle other) //Equals - check if an instance of Vehicle is the same as this instance
        {
            if (other == null) return false;
            if (this.RegNumber == other.RegNumber) return true;
            else return false;
        }
        public override bool Equals(object obj) //Equals - Check if an object is same type as Vehicle
        {
            if (obj == null) return false;

            Vehicle vehicleObject = obj as Vehicle;
            if (vehicleObject == null) return false;
            else return Equals(vehicleObject);
        }
    }
}
