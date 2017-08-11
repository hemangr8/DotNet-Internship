using System;

class TestSwitch
{
    static void Main()
    {
        Console.WriteLine("Enter choice of programming language");
        string PL = Console.ReadLine();
        switch (PL.ToUpper())
        {
            case "VB":
                Console.WriteLine("VB .NET: OOP, multithreading and more!");
                break;
            case "C#":
                Console.WriteLine("God choice of programming language");
                break;
            default:
                Console.WriteLine("Good luck with that!");
                break;
        }
    }
}
