using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystem
{
    class Car:Vehicle
    {
        public string model { set; get; }

        public Car()
        {
            Price = 65;
        }
    }
}
