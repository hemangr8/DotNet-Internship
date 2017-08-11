using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternAssignment
{
    /// <summary>
    ///This is the adapter which hepls in establishing a ommunication between the computer and the Mouse
    /// </summary>
    public class USBAdapter
    {
        Mouse mouse = new Mouse();
        public void Adaptor()
        {
            mouse.ConnectToAdapter();
            Console.WriteLine("This Is The USB Adapter Working After Receiving The Signal From Mouse....");
            Console.WriteLine("Converting the recieved signal from mouse.");
            Console.WriteLine("Sending Signal to Computer");
            Console.WriteLine("");
        }
    }
}
