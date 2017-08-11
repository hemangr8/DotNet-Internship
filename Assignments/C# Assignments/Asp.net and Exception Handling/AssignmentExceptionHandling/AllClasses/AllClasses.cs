using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

public class Vehicle
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
    public void ShowDetails()
    {
        Console.WriteLine("The Make is: {0}", make);
        Console.WriteLine("The year of manufacture is {0}", yearOfManufacture);
        Console.WriteLine("The model {0}", model);
        Console.WriteLine("The Speed is {0}", speed);
    }
}

public class Bicycle : Vehicle
{
    private int _noOfGears;
    public Bicycle(int NoOfGears)
        : base(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), float.Parse(Console.ReadLine()))
    {
        _noOfGears = NoOfGears;
    }
    public bool IsBicycleSpeed100()
    {
        if (speed >= 100)
            return true;
        else
            return false;
    }
    public bool IsBicycleSpeed95()
    {
        if (speed >= 95)
            return true;
        else
            return false;
    }
    public void ShowNoOfGears()
    {
        Console.WriteLine("No. of gears is: {0}", _noOfGears);
    }
}

public class Bike : Vehicle
{
    private int _turnRadius;
    public Bike(int TurnRadius)
        : base(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), float.Parse(Console.ReadLine()))
    {
        _turnRadius = TurnRadius;
    }
    public void ShowTurnRadius()
    {
        Console.WriteLine("Turn Radius is: {0}", _turnRadius);
    }
}

public class Car : Vehicle
{
    private int _countAccelerations = 0;
    private int _countDeaccelerations = 0;
    private string _engine;
    public Car(string Engine)
        : base(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), float.Parse(Console.ReadLine()))
    {
        _engine = Engine;
    }

    public bool IsSpeed140()
    {
        if (speed >= 140)
            return true;
        else
            return false;
    }

    /// <summary>
    /// If the car is accelerated or deaccelerated more than 4 times:
    /// It will be an exception of type IsCarDeadException and It will give a message that the car has overheated
    /// If the car is accelerated beyond 140Km/hr OR If the entered speed is more than 140Km/hr:
    /// It will be an exception of type IsCarDeadException and It will give a message that the car has exploded
    /// </summary>

    new public void Accelerate()
    {
        _countAccelerations++;
        if (_countAccelerations > 4)
        {
            try
            {
                throw new IsCarDeadException("The Car has overheated");
            }
            catch (IsCarDeadException carOverheat)
            {
                Console.WriteLine(carOverheat.Message + " The car can't be accelerated");
                //ClassForLogging.LogCustomException(carOverheat.Message);
            }
        }
        else if ((speed + 5) > 140)
        {
            try
            {
                throw new IsCarDeadException("The Car has exploaded");
            }
            catch (IsCarDeadException carExploded)
            {
                Console.WriteLine(carExploded.Message);
                //ClassForLogging.LogCustomException(carExploded.Message);
            }
        }
        else
        {
            speed += 5;
            Console.WriteLine("Vehicle Accelerated. Speed={0}" , speed);
        }
    }
    new public void Deaccelerate()
    {
        _countDeaccelerations++;
        if (_countDeaccelerations > 4)
        {
            try
            {
                throw new IsCarDeadException("The Car has overheated");
            }
            catch (IsCarDeadException carOverheat)
            {
                Console.WriteLine(carOverheat.Message + " The car can't be deaccelerated");
                //ClassForLogging.LogCustomException(carOverheat.Message);
            }
        }
        else if (speed == 0)
            Console.WriteLine("Vehicle Stopped can't deaccelerate");
        else if (speed <= 5)
        {
            speed = 0;
            Console.WriteLine("Vehicle Deaccelerated. Speed={0}" , speed);
        }
        else
        {
            speed -= 5;
            Console.WriteLine("Vehicle Deaccelerated. Speed={0}", speed);
        }
    }
    public void ShowEngine()
    {
        Console.WriteLine("Engine is: {0}", _engine);
    }
}

public class Truck : Vehicle
{
    private int _capacity;
    public Truck(int Capacity)
        : base(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), float.Parse(Console.ReadLine()))
    {
        _capacity = Capacity;
    }
    public void ShowCapacity()
    {
        Console.WriteLine("Capacity is: {0}", _capacity);
    }
}
