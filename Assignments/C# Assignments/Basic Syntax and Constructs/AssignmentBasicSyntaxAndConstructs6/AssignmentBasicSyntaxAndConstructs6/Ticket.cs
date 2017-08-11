using System;

namespace AssignmentBasicSyntaxAndConstructs6
{
    public class Ticket
    {
        private int _ticketId;
        private string _name;
        private string _destionation;
        public void GetDetails(int ID, string Name, string Destination)
        {
            _ticketId = ID;
            _name = Name;
            _destionation = Destination;
        }
        public void ShowDetails()
        {
            Console.WriteLine("The entered details are:");
            Console.WriteLine("{0} , {1} , {2}", _ticketId, _name, _destionation);
        }
    }

}
