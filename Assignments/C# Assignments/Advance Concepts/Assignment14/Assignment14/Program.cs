using System;
using System.Collections.Generic;

namespace Assignment14
{
    class Program
    {
        public static void Main()
        {
            var mainVehicle = new Vehicle()
            {
                Name = "Tesla",
                Model = "Auto Pilot",
                Speed = 70
            };

            var secondaryVehicle = new Vehicle()
            {
                Name = "Tesla",
                Model = "Auto Pilot",
                Speed = 70
            };

            var newCar = new Car()
            {
                Name = "Lamborghini",
                Model = "Viper",
                Speed = 123,
                MaxSpeed = 200
            };

            var newTruck = new Truck()
            {
                Name = "TATA",
                Model = "H22",
                Speed = 50,
                Capacity = 300
            };

            List<Vehicle> vehicles = new List<Vehicle>
            {
                mainVehicle,
                newCar,
                newTruck,
                secondaryVehicle
            };

            Console.WriteLine("Before sorting");
            int countBeforeSorting = 1;
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("Vehicle No . :{0}", countBeforeSorting);
                Console.WriteLine("Name : {0}, Model : {1}, Speed : {2}", vehicle.Name, vehicle.Model, vehicle.Speed);
                countBeforeSorting++;
            }

            vehicles.Sort();

            int countAfterSorting = 1;
            Console.WriteLine("");
            Console.WriteLine("After Sorting by vehicles name : ");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("Vehicle No . :{0}", countAfterSorting);
                Console.WriteLine("Name : {0}, Model : {1}, Speed : {2}", vehicle.Name, vehicle.Model, vehicle.Speed);
                countAfterSorting++;
            }

            Console.WriteLine("");
            Console.WriteLine("Checking objects for equality");
            Console.WriteLine("Equality between Main Vehicle And Car:");
            Console.WriteLine(mainVehicle.Equals(newCar));

            Console.WriteLine("");
            Console.WriteLine("Checking objects for equality");
            Console.WriteLine("Equality between Truck And Car:");
            Console.WriteLine(newTruck.Equals(newCar));

            Console.WriteLine("");
            Console.WriteLine("Checking objects for equality");
            Console.WriteLine("Equality between Main Vehicle And Secondary Vehicle:");
            Console.WriteLine(mainVehicle.Equals(secondaryVehicle));
        }
    }
}
