using System;

namespace GarageSystem
{
    class Car : Vehicle
    {
        public string model { set; get; } //Car model

        public Car()
        {
            ParkingPrice = 65; //Default price for Car
        }
    }
}
