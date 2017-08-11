using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string finalChoice = null;
        do
        {
            Console.WriteLine("Which Vehicle do you have");
            Console.WriteLine("1.Bicycle");
            Console.WriteLine("2.Bike");
            Console.WriteLine("3.Car");
            Console.WriteLine("4.Truck");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        VehicleCases vehicleCase = new VehicleCases();
                        vehicleCase.BicycleCase();
                    }
                    break;
                case 2:
                    {
                        VehicleCases vehicleCase = new VehicleCases();
                        vehicleCase.BikeCase();
                    }
                    break;
                case 3:
                    {
                        VehicleCases vehicleCase = new VehicleCases();
                        vehicleCase.CarCase();
                    }
                    break;
                case 4:
                    {
                        VehicleCases vehicleCase = new VehicleCases();
                        vehicleCase.TruckCase();
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.WriteLine("Do you want to perform operations on another vehicle?(Yes/No)");
            finalChoice = Console.ReadLine();
        } while (string.Compare(finalChoice, "Yes") == 0);
    }
}