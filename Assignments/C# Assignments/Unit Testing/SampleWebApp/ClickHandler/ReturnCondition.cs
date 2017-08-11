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
            bool returnValue = false;
            try
            {
                float tempPercent = float.Parse(text);
            }
            catch (Exception)
            {
                returnValue = true;
            }
            return returnValue;
        }
        public bool IslLegit(string text)
        {
            float tempPercent = float.Parse(text);
            if ((tempPercent >= 0) && (tempPercent <= 100))
                return true;
            else
                return false;
        }
        public bool IsPassed(string text)
        {
            float tempPercentage = float.Parse(text);
            if (tempPercentage > 30)
                return true;
            else
                return false;
        }
    }
}
