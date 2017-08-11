using System;


class TestIf
{
   static void Main()
   {
       Console.WriteLine("Enter choice of Programming Language");
       string ProgrammingLanguage = Console.ReadLine();
       if (string.Compare(ProgrammingLanguage, "VB") == 0)
       {
           Console.WriteLine("VB .NET: OOP, multithreading and more!");
       }
       else if (string.Compare(ProgrammingLanguage, "C#") == 0)
       {
           Console.WriteLine("Good choice, C# is a fine language.");
       }
       else
       {
           Console.WriteLine("Well...good luck with that!");
       }
   }
}
