using System;

namespace GarageSystem
{
    class Bus : Vehicle
    {

        #region Proporties
        public int pSeats { set; get; } //Antal passagerar platser för buss
        #endregion

        #region Constructor
        public Bus()
        {
            ParkingPrice = 200; //Default price for Bus
        }
        #endregion
 
    }
}
