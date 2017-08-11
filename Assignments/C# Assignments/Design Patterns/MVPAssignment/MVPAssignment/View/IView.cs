using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPAssignment
{
    public interface IView
    {
        String Label { get; set; }
        String TextBox { get; set; }
    }
}
