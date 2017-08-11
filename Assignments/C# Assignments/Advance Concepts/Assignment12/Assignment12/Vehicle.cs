using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public class Vehicle : System.Object, IComparable<Vehicle>, IEquatable<Vehicle>, IComparer<Vehicle>
    {
        public string make;
        public int yearOfManufacture;
        public string model;
        public float speed;
        public Vehicle(string Make, int YearOfManufacture, string Model, float Speed)
        {
            make = Make;
            yearOfManufacture = YearOfManufacture;
            model = Model;
            speed = Speed;
        }
        public void Accelerate()
        {
            speed += 5;
        }
        public void Deaccelerate()
        {
            if (speed == 0)
                Console.WriteLine("Vehicle Stopped can't deaccelerate");
            else if (speed <= 5)
            {
                speed = 0;
                Console.WriteLine("Vehicle Deaccelerated");
            }
            else
            {
                speed -= 5;
                Console.WriteLine("Vehicle Deaccelerated");
            }
        }
        public void Stop()
        {
            speed = 0;
        }
        public Boolean isMoving()
        {
            Boolean a = speed != 0 ? true : false;
            return a;
        }
        public Vehicle() 
        { 
        }
        public void ShowDetails()
        {
            Console.WriteLine("The Make is: {0}", make);
            Console.WriteLine("The year of manufacture is {0}", yearOfManufacture);
            Console.WriteLine("The model {0}", model);
            Console.WriteLine("The Speed is {0}", speed);
        }

        public int CompareTo(Vehicle other)                   //Implementing IComparable
        {
            if (
                this.yearOfManufacture > other.yearOfManufacture
                || this.make != other.make
                || this.model != other.model
                )
                return 1;
            else if (
                this.yearOfManufacture < other.yearOfManufacture
                || this.make != other.make
                || this.model != other.model
                )
                return -1;
            else
                return 0;
        }

        public override bool Equals(System.Object vehicle)          //Override Equals (method in object class)
        {
            Vehicle obj = (Vehicle)vehicle;

            if (obj == null)
                return false;
            else if (!(obj is Vehicle))
                return false;
            else
                return
                    (
                    obj.make == this.make &&
                    obj.model == this.model &&
                    obj.speed == this.speed &&
                    obj.yearOfManufacture == this.yearOfManufacture
                    );
        }

        public bool Equals(Vehicle vehicle)            // Implementation of IEquitable
        {
            Vehicle obj = (Vehicle)vehicle;

            if (obj == null)
                return false;
            else if (!(obj is Vehicle))
                return false;
            else
                return
                    (
                    obj.make == this.make &&
                    obj.model == this.model &&
                    obj.speed == this.speed &&
                    obj.yearOfManufacture == this.yearOfManufacture
                    );
        }

        public int Compare(Vehicle x, Vehicle y)
        {

            return x.CompareTo(y);
        }

    }
}
