using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Strings:");
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            Comparer comparer = Comparer.GetComparerInstance();
            Console.WriteLine("Are strings Equal : " + comparer.IsStringEqual(string1, string2));
            MainComparision1();
            MainComparision2();
        }

        private static void MainComparision1()
        {
            Console.WriteLine("Enter 2 Strings:");
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            Comparer comparer = Comparer.GetComparerInstance();
            Console.WriteLine("Are strings Equal : " + comparer.IsStringEqual(string1, string2));
        }

        private static void MainComparision2()
        {
            Console.WriteLine("Enter 2 Strings:");
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            Comparer comparer = Comparer.GetComparerInstance();
            Console.WriteLine("Are strings Equal : " + comparer.IsStringEqual(string1, string2));
        }
    }
}
