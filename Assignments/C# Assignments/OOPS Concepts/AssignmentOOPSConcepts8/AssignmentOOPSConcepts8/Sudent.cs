using System;

class Program
{
    static void Main()
    {
        string FinalChoice = null;
        Console.WriteLine("Enter details of the student in the order: Name, Age, Class");
        Student S = new Student(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        do
        {
            Console.WriteLine("Enter choice");
            Console.WriteLine("1. See all details");
            Console.WriteLine("2. See specific detail");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    S.ShowDetails();
                    break;
                case 2:
                    Console.WriteLine("Which detail to show?");
                    Console.WriteLine("1. ID");
                    Console.WriteLine("2. Name");
                    Console.WriteLine("3. Age");
                    Console.WriteLine("4. Class");
                    int ch = int.Parse(Console.ReadLine());
                    S.PrintSpecific(ch);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine("Do you want to see details again?(Yes,No)");
            FinalChoice = Console.ReadLine();
        } while (string.Compare(FinalChoice, "Yes") == 0);
    }
}

