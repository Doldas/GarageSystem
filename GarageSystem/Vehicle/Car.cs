using System;

namespace GarageSystem
{

    class Car : Vehicle
    {

        #region Property
        public string model { set; get; } //Car model
        #endregion

        #region Constructor
        public Car()
        {
            ParkingPrice = 65; //Default price for Car 
        }
        #endregion

    }

}
