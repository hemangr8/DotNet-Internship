using System;
using System.Collections;

namespace CollectionsNLists2
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCar = new Vehicle()
            {
               Name = "Baleno",
               Model = "TDi",
               Speed = 120
            };

            var newTruck = new Vehicle()
            {
               Name = "TATA",
               Model = "H22x",
               Speed = 90
            };

            var newBike = new TwoWheeler()
            {
               Name ="Apache",
               Model = "RtR",
               Speed = 100
            };

            ArrayList vehicles = new ArrayList
            {
                newCar,
                newTruck,
                newBike
            };
            Console.WriteLine("Enumerating through the list contents and using tostring method for printing.");

            foreach( var vehicle in vehicles )
            {
                Console.WriteLine(vehicle.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine("Gettting the list element using indexes");
            for (int i = 0; i < vehicles.Count; i++)
            {
                Console.WriteLine("Name : {0}, Model : {1}, Speed {2}", ((Vehicle)vehicles[i]).Name, ((Vehicle)vehicles[i]).Model, ((Vehicle)vehicles[i]).Speed);

                Console.WriteLine("The Name of the viehicle : {0} is modified to : {1}",((Vehicle)vehicles[i]).Name, ((Vehicle)vehicles[i]).Name = "X");
            }

            Console.WriteLine("");
            Console.WriteLine("Calling ToString from object");
            Console.WriteLine(Convert.ToString(newBike));
            Console.WriteLine(Convert.ToString(newCar));
        }
    }
}
