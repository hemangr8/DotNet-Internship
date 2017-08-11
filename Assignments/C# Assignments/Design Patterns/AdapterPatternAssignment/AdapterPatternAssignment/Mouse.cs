using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternAssignment
{
    /// <summary>
    /// This is the mouse clkass which will communicate to the computer class
    /// with the help of the USB adapter class
    /// </summary>
    public class Mouse
    {
        public void ConnectToAdapter()
        {
            Console.WriteLine("This Is The Mouse Working......");
            Console.WriteLine("Sending signal to USB Adapter");
            Console.WriteLine("");
        } 
    }
}
