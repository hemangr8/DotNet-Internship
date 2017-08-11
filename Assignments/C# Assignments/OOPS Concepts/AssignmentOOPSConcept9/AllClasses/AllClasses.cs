using System;

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
        if (speed <= 5)
            speed = 0;
        else
            speed -= 5;
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
    private string _engine;
    public Car(string Engine)
        : base(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), float.Parse(Console.ReadLine()))
    {
        _engine = Engine;
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
