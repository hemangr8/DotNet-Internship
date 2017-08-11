using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public class VehicleCollection : IEnumerable<Vehicle>
    {
        Vehicle[] vehiclelist = new Vehicle[5];
        int count = 0;

        public void Add(Vehicle v)
        {
            if (count == vehiclelist.Length)
                Array.Resize(ref vehiclelist, vehiclelist.Length * 2);

            vehiclelist[count++] = v;
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return vehiclelist[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
