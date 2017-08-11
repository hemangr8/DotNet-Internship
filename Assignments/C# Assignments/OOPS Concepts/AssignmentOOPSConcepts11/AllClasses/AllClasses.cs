using System;

public class Student
{
    protected int rollNo;
    protected string fullName;

    public Student(int RollNo, String FullName)
    {
        this.rollNo = RollNo;
        this.fullName = FullName;
    }
}

public class SchoolStudent : Student
{
    private int _class;

    public SchoolStudent(int Class)
        : base(int.Parse(Console.ReadLine()), Console.ReadLine())
    {
        _class = Class;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("The Roll No is:{0} Fulll Name is:{1} Class is:{2}", rollNo, fullName, _class);
    }
}

public class CollegeStudent : Student
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

