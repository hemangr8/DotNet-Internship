using AssignmentBasicSyntaxAndConstructs6;
using System;

class Encapsulation
{
    static void Main()
    {
        Ticket T1= new Ticket();
        T1.GetDetails(1, "Himanshu", "Noida");
        T1.ShowDetails();
    }
}

