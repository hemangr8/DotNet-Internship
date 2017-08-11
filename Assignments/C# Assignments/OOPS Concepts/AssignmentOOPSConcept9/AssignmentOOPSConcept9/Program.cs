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

public class Bicycle: Vehicle
{
    private int _noOfGears;
    public Bicycle(int NoOfGears): base(Console.ReadLine(), int.Parse(Console.ReadLine()),Console.ReadLine(),float.Parse(Console.ReadLine()))
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
    public Bike(int TurnRadius): base(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), float.Parse(Console.ReadLine()))
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
    public Car(string Engine): base(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), float.Parse(Console.ReadLine()))
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
    public Truck(int Capacity): base(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), float.Parse(Console.ReadLine()))
    {
        _capacity = Capacity;
    }
    public void ShowCapacity()
    {
        Console.WriteLine("Capacity is: {0}", _capacity);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Which Vehicle do you have");
        Console.WriteLine("1.Bicycle");
        Console.WriteLine("2.Bike");
        Console.WriteLine("3.Car");
        Console.WriteLine("4.Truck");
        int Choice = int.Parse(Console.ReadLine());
        switch (Choice)
        {
            case 1:
                {
                    Console.WriteLine("Enter Details of the vehicle in the orde: Make, Year Of Manufacture, Model, Speed, No. Of Gears");
                    Bicycle B = new Bicycle(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Now what operation you want to perform");
                    Console.WriteLine("1. See Details");
                    Console.WriteLine("2. Accelerate Vehicle");
                    Console.WriteLine("3. Deaccelerate Vehicle");
                    Console.WriteLine("4. Stop vehicle");
                    Console.WriteLine("5. Check moving or stopped");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            B.ShowDetails();
                            B.ShowNoOfGears();
                            break;
                        case 2:
                            B.Accelerate();
                            Console.WriteLine("Vehicle Accelerated");
                            break;
                        case 3:
                            B.Deaccelerate();
                            Console.WriteLine("Vehicle Deaccelerated");
                            break;
                        case 4:
                            B.Stop();
                            Console.WriteLine("Vehicle Stopped");
                            break;
                        case 5:
                            if (B.isMoving())
                                Console.WriteLine("Moving");
                            else
                                Console.WriteLine("Stopped");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }
                break;
            case 2:
                {
                    Console.WriteLine("Enter Details of the vehicle in the orde: Make, Year Of Manufacture, Model, Speed, Turn Radius");
                    Bike B = new Bike(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Now what operation you want to perform");
                    Console.WriteLine("1. See Details");
                    Console.WriteLine("2. Accelerate Vehicle");
                    Console.WriteLine("3. Deaccelerate Vehicle");
                    Console.WriteLine("4. Stop vehicle");
                    Console.WriteLine("5. Check moving or stopped");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            B.ShowDetails();
                            B.ShowTurnRadius();
                            break;
                        case 2:
                            B.Accelerate();
                            Console.WriteLine("Vehicle Accelerated");
                            break;
                        case 3:
                            B.Deaccelerate();
                            Console.WriteLine("Vehicle Deaccelerated");
                            break;
                        case 4:
                            B.Stop();
                            Console.WriteLine("Vehicle Stopped");
                            break;
                        case 5:
                            if (B.isMoving())
                                Console.WriteLine("Moving");
                            else
                                Console.WriteLine("Stopped");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }
                break;
            case 3:
                {
                    Console.WriteLine("Enter Details of the vehicle in the orde: Make, Year Of Manufacture, Model, Speed, type of Engine");
                    Car C = new Car(Console.ReadLine());
                    Console.WriteLine("Now what operation you want to perform");
                    Console.WriteLine("1. See Details");
                    Console.WriteLine("2. Accelerate Vehicle");
                    Console.WriteLine("3. Deaccelerate Vehicle");
                    Console.WriteLine("4. Stop vehicle");
                    Console.WriteLine("5. Check moving or stopped");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            C.ShowDetails();
                            C.ShowEngine();
                            break;
                        case 2:
                            C.Accelerate();
                            Console.WriteLine("Vehicle Accelerated");
                            break;
                        case 3:
                            C.Deaccelerate();
                            Console.WriteLine("Vehicle Deaccelerated");
                            break;
                        case 4:
                            C.Stop();
                            Console.WriteLine("Vehicle Stopped");
                            break;
                        case 5:
                            if (C.isMoving())
                                Console.WriteLine("Moving");
                            else
                                Console.WriteLine("Stopped");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }
                break;
            case 4:
                {
                    Console.WriteLine("Enter Details of the vehicle in the orde: Make, Year Of Manufacture, Model, Speed, Capacity");
                    Truck T = new Truck(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Now what operation you want to perform");
                    Console.WriteLine("1. See Details");
                    Console.WriteLine("2. Accelerate Vehicle");
                    Console.WriteLine("3. Deaccelerate Vehicle");
                    Console.WriteLine("4. Stop vehicle");
                    Console.WriteLine("5. Check moving or stopped");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            T.ShowDetails();
                            T.ShowCapacity();
                            break;
                        case 2:
                            T.Accelerate();
                            Console.WriteLine("Vehicle Accelerated");
                            break;
                        case 3:
                            T.Deaccelerate();
                            Console.WriteLine("Vehicle Deaccelerated");
                            break;
                        case 4:
                            T.Stop();
                            Console.WriteLine("Vehicle Stopped");
                            break;
                        case 5:
                            if (T.isMoving())
                                Console.WriteLine("Moving");
                            else
                                Console.WriteLine("Stopped");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }
                break;
            default:
                Console.WriteLine("error");
                break;
        }
    }
}
