using System;


class Student
{
    protected int rollNo;
    protected string fullName;

    public Student(int RollNo, String FullName)
    {
        this.rollNo = RollNo;
        this.fullName = FullName;
    }
}

class SchoolStudent : Student
{
    private int _class;

    public SchoolStudent(int Class)
        : base(int.Parse(Console.ReadLine()), Console.ReadLine())
    {
        _class = Class;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("The Roll No is:{0} Fulll Name is:{1} Class is{2}", rollNo, fullName, _class);
    }
}

class CollegeStudent : Student
{
    private string _course;
    private int _year;

    public CollegeStudent(string Course, int Year)
        : base(int.Parse(Console.ReadLine()), Console.ReadLine())
    {
        _year = Year;
        _course = Course;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("The Roll No is:{0} Fulll Name is:{1} Course is{2} Year is:{3}", rollNo, fullName, _course, _year);
    }
}

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