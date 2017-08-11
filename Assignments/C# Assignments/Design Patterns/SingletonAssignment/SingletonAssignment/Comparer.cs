using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAssignment
{
    public class Comparer
    {
        private static Comparer comparer = null;

        private Comparer()
        {
 
        }

        public static Comparer GetComparerInstance()
        {
            if (comparer == null)
            {
                comparer = new Comparer();
                return comparer;
            }
            else
                return comparer;
        }

        public bool IsStringEqual(string string1, string string2)
        {
            return string1.Equals(string2);
        }
    }
}
