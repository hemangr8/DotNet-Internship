using System;


class TestEnum
{
    static void Main(string[] args)
    {
        Console.WriteLine("The following are week days");
        Console.WriteLine(WeekDay.Monday);
        Console.WriteLine(WeekDay.Tuesday);
        Console.WriteLine(WeekDay.Wednesday);
        Console.WriteLine(WeekDay.Thursday);
        Console.WriteLine(WeekDay.Friday);
    }
}

public enum WeekDay
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday
}