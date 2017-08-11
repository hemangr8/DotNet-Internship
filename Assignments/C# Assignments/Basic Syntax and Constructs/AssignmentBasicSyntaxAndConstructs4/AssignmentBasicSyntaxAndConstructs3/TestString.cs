using System;

class TestStrings
{
    static void Main()
    {
        Console.WriteLine("Enter 2 string");
        string Str1 = Console.ReadLine();
        string Str2 = Console.ReadLine();
        Console.WriteLine("What operation do you want:");
        Console.WriteLine("1. Compare");
        Console.WriteLine("2. Copy string 2 in string 1");
        Console.WriteLine("3. Concatinate");
        int Choice = int.Parse(Console.ReadLine());
        switch(Choice)
        {
            case 1:
                if (string.Compare(Str1, Str2) == 0)
                    Console.WriteLine("The strings are equal");
                else
                    Console.WriteLine("Strings are not equal");
                break;
            case 2:
                Str1 = String.Copy(Str2);
                Console.WriteLine("The srtimg 1 after copying: {0}", Str1);
                break;
            case 3:
                string.Concat(Str1, Str2);
                Console.WriteLine("The srtimg 1 after concatinating: {0}", Str1);
                break;
            default:
                Console.WriteLine("Error in choice");
                break;
        }
    }
}
