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
            pSeats = 49; //The default value for amount of passanger seats
            ParkingPrice = 200; //Default price for Bus
        }
        #endregion
 
    }
}
