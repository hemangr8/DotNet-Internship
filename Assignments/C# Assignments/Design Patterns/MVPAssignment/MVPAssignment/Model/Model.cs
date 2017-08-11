using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVPAssignment
{
    public class Model : IModel
    {
        public List<String> setInfo()
        {
            List<String> l = new List<string>();
            l.Add("Enter Name:");
            l.Add("Use capital letter only");
            return l;
        }
    }
}