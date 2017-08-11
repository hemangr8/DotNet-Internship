using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("What kind of student are you");
        Console.WriteLine("1. School Student");
        Console.WriteLine("2. College Student");
        Console.WriteLine("Enter Your Choice");
        int Choice = int.Parse(Console.ReadLine());
        switch (Choice)
        {
            case 1:
                {
                    Console.WriteLine("Enter Your details: in the order Class, RollNo, Full Name");
                    var SStud = new SchoolStudent(int.Parse(Console.ReadLine()));
                    Console.WriteLine("The Details you entered are :");
                    SStud.DisplayDetails();
                }
                break;
            case 2:
                {
                    Console.WriteLine("Enter Your details: in the order Course, Year, RollNo, Full Name");
                    var CStud = new CollegeStudent(Console.ReadLine(), int.Parse(Console.ReadLine()));
                    Console.WriteLine("The Details you entered are :");
                    CStud.DisplayDetails();
                }
                break;
            default:
                Console.WriteLine("Error in choice");
                break;
        }
    }
}