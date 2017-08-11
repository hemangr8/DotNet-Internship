using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
        class Vehicle : IComparable<Vehicle>, IEquatable<Vehicle>
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public float Speed { get; set; }
        
            public int CompareTo(Vehicle other)
            {
                return this.Name.CompareTo(other.Name);
            }

            public bool Equals(Vehicle other)
            {
                return ((Name == other.Name) && (Model == other.Model));
            }  
       }
}
