using System;
using System.Collections.Generic;
using System.Collections;

namespace Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[3];

            Console.WriteLine("Add 3 vehicles in array");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter details for the vehicles : {0} in the order, Year Of Manufacture, model, Speed:",i+1);
                vehicles[i] = new Vehicle(Console.ReadLine(),int.Parse(Console.ReadLine()),Console.ReadLine(),float.Parse(Console.ReadLine()));
            }

            Console.WriteLine("");

            Console.WriteLine("Order before Sorting:");

            for (int i = 0; i < 3; i++)
            {
                vehicles[i].ShowDetails();
                Console.WriteLine("Status of Moving : " + vehicles[i].isMoving());
                Console.WriteLine("");
            }

            Array.Sort(vehicles);

            Console.WriteLine("");
            Console.WriteLine("Order after Sorting:");

            for (int i = 0; i < 3; i++)
            {
                vehicles[i].ShowDetails();
                Console.WriteLine("Status of Moving: " + vehicles[i].isMoving());
                Console.WriteLine("");
            }


            Vehicle v1 = new Vehicle()
            {
                make = "Mercedes",
                model = "GT599",
                yearOfManufacture = 2014,
                speed = 400
            };

            Vehicle v2 = new Vehicle()
            {
                make = "Lambourghini",
                model = "GT599",
                yearOfManufacture = 2004,
                speed = 450
            };

            Vehicle v3 = new Vehicle()
            {
                make = "Ferrari",
                model = "Brrrrrrr",
                yearOfManufacture = 1999,
                speed = 300
            };

            Vehicle v4 = new Vehicle()
            {
                make = "Mercedes",
                model = "FS250",
                yearOfManufacture = 2015,
                speed = 40
            };

            Vehicle v5 = new Vehicle()
            {
                make = "Ford",
                model = "Mustang",
                yearOfManufacture = 1970,
                speed = 200
            };

            Vehicle v6 = new Vehicle()
            {
                make = "Ford",
                model = "Mustang",
                yearOfManufacture = 1970,
                speed = 200
            };

            Console.WriteLine("");
            
            VehicleCollection list = new VehicleCollection();

            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            list.Add(v4);
            list.Add(v5);
            list.Add(v6);
            int countVehicles = 1;

            foreach (Vehicle item in list)
            {
                Console.WriteLine("The vehicle no. {0} is", countVehicles);
                item.ShowDetails();
                countVehicles++;
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("The status of equality between Vehicle No. 1 and Vehicle NO. 2 is:");
            Console.WriteLine(v2.Equals(v1));

            Console.WriteLine("");
            Console.WriteLine("The status of equality between Vehicle No. 3 and Vehicle NO. 4 is:");
            Console.WriteLine(v3.Equals(v4));

            Console.WriteLine("");
            Console.WriteLine("The status of equality between Vehicle No. 5 and Vehicle NO. 5 is:");
            Console.WriteLine(v6.Equals(v5));
        }
    }
}
