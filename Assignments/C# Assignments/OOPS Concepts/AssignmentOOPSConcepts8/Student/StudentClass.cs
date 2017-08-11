using System;

public class Student
{
    Random rnd = new Random();
    private int _id;
    private string _name;
    private int _age;
    private int _class;
    public enum StudentAttribute
    {
        ID = 1,
        Name,
        Age,
        Class
    }
    public Student(string Name, int Age, int Class)
    {
        _id = rnd.Next(1, 1000);
        _name = Name;
        _class = Class;
        _age = Age;
    }
    public void ShowDetails()
    {
        Console.WriteLine("Welcome {0}", _name);
        Console.WriteLine("Your ID is {0}", _id);
        Console.WriteLine("Your Entered age is:{0} and your class is:{1}", _age, _class);
    }
    public void PrintSpecific(int a)
    {
        StudentAttribute Detail = (StudentAttribute)a;
        switch (Detail)
        {
            case StudentAttribute.ID:
                Console.WriteLine("The ID is:{0}", _id);
                break;
            case StudentAttribute.Class:
                Console.WriteLine("The Class is:{0}", _class);
                break;
            case StudentAttribute.Name:
                Console.WriteLine("The Name is:{0}", _name);
                break;
            case StudentAttribute.Age:
                Console.WriteLine("The age is:{0}", _age);
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
}
