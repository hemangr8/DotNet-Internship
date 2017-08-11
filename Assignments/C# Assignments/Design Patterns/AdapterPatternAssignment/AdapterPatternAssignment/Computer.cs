using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternAssignment
{
    class Computer
    {
        /// <summary>
        /// This program implements theadapter pattern
        /// Just like a mouse communicates to a computer using a USB port
        /// with the help of an adapter
        /// </summary>
        static void Main(string[] args)
        {
            USBAdapter usb = new USBAdapter();
            usb.Adaptor();
            Console.WriteLine("This Is The Computer Working After Receiving The Signal From Mouse Through The Adapter");
            Console.WriteLine("Recieved signal from mouse");
        }
    }
}
