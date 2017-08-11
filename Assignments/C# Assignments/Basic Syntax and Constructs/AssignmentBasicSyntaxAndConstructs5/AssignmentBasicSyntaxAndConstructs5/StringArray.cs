using System;

class StringArr
{
    public static string[] GetStringArray()
    {
        string[] SArray = new string[5];
        SArray[0] = "Himanshu";
        SArray[1] = "Himanshu1";
        SArray[2] = "Himanshu2";
        SArray[3] = "Himanshu3";
        SArray[4] = "Himanshu4";
        return SArray;
    }
    static void Main()
    {
        string[] StringArray = GetStringArray();
        Console.WriteLine("The string array:");
        foreach (string value in StringArray)
        {
            Console.WriteLine(value);
        }
    }
}