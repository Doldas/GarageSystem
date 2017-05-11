using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSystem
{
    class Vehicle : IEquatable<Vehicle>,IComparable<Vehicle>
    {
        bool IEquatable<Vehicle>.Equals(Vehicle other)
        {
            throw new NotImplementedException();
        }

        int IComparable<Vehicle>.CompareTo(Vehicle other)
        {
            throw new NotImplementedException();
        }
    }
}
