using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystem
{
    class Vehicle : IEquatable<Vehicle>
    {
        public string regNumber { set; get; }

        //Check if a vehicle is the same as another vehicle
        bool IEquatable<Vehicle>.Equals(Vehicle other)
        {
            return this.regNumber == other.regNumber;
        }
        override bool IEquatable<Vehicle>.Equals(object other)
        {
            /*
            Vehicle vehicle = other as Vehicle; 
             * In theory a class Car should be true here because of inheritance, but not sure until later testing
             * If the code above works we can remove all other casts
             */
            Car car = other as Car;
            Bus bus = other as Buss;
            Motorcycle motorcycle = other as Motorcycle;
           //If these variables are empty, return false because that means it isn't a vehicle
            if(car==null && bus==null && motorcycle==null)
            {
                return false;
            }
            //Else return true
            return true;
        }
    }
}
