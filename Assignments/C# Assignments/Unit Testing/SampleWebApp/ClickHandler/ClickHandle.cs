using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentageConditions
{
    public class ReturnConditions
    {
        public bool IsException(string text)
        {
            bool e = false;
            try
            {
                int tempPercent = int.Parse(text);
            }
            catch (Exception)
            {
                e = true;
            }
            return e;
        }

    }
}
