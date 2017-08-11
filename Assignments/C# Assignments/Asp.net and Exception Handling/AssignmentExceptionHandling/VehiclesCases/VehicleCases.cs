using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


public class VehicleCases
{
    public void BicycleCase()
    {
        Console.WriteLine("Enter Details of the vehicle in the orde: No. Of Gears, Make, Year Of Manufacture, Model, Speed");
        Bicycle bicycle = new Bicycle(int.Parse(Console.ReadLine()));
        if (bicycle.IsBicycleSpeed100())
        {
            Console.WriteLine("The speed value is not possible enter acceptable speed");
        }
        else
        {
            string operationChoice = null;
            do
            {
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
                        bicycle.ShowDetails();
                        bicycle.ShowNoOfGears();
                        break;
                    case 2:
                        if (bicycle.IsBicycleSpeed95())
                            Console.WriteLine("Speed is more than acceptable limit can't accelerate");
                        else
                        {
                            bicycle.Accelerate();
                            Console.WriteLine("Vehicle Accelerated");
                        }
                        break;
                    case 3:
                        bicycle.Deaccelerate();
                        break;
                    case 4:
                        bicycle.Stop();
                        Console.WriteLine("Vehicle Stopped");
                        break;
                    case 5:
                        if (bicycle.isMoving())
                            Console.WriteLine("Moving");
                        else
                            Console.WriteLine("Stopped");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.WriteLine("Do you want to perform another operation om this vehicle?(Yes/No)");
                operationChoice = Console.ReadLine();
            } while (string.Compare(operationChoice, "Yes") == 0);
        }    
    }

    public void BikeCase()
    {
        Console.WriteLine("Enter Details of the vehicle in the orde: Turn Radius, Make, Year Of Manufacture, Model, Speed");
        Bike bike = new Bike(int.Parse(Console.ReadLine()));
        string operationChoice = null;
        do
        {
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
                    bike.ShowDetails();
                    bike.ShowTurnRadius();
                    break;
                case 2:
                    bike.Accelerate();
                    Console.WriteLine("Vehicle Accelerated");
                    break;
                case 3:
                    bike.Deaccelerate();
                    break;
                case 4:
                    bike.Stop();
                    Console.WriteLine("Vehicle Stopped");
                    break;
                case 5:
                    if (bike.isMoving())
                        Console.WriteLine("Moving");
                    else
                        Console.WriteLine("Stopped");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine("Do you want to perform another operation om this vehicle?(Yes/No)");
            operationChoice = Console.ReadLine();
        } while (string.Compare(operationChoice, "Yes") == 0);
    }


    /// <summary>
    /// If the car is accelerated or deaccelerated more than 4 times:
    /// It will be an exception of type IsCarDeadException and It will give a message that the car has overheated
    /// If the car is accelerated beyond 140Km/hr OR If the entered speed is more than 140Km/hr:
    /// It will be an exception of type IsCarDeadException and It will give a message that the car has exploded
    /// </summary>


    public void CarCase()
    {
        Console.WriteLine("Enter Details of the vehicle in the orde: Type Of Engine, Make, Year Of Manufacture, Model, Speed");
        Car car = new Car(Console.ReadLine());
        if (car.IsSpeed140())
        {
            try
            {
                throw new IsCarDeadException("Car has exploded");
            }
            catch (IsCarDeadException carExplode)
            {
                Console.WriteLine(carExplode.Message + " Enter valid speed less than 140");
                ClassForLogging.LogCustomException(carExplode.Message);
            }
        }
        else
        {
            string operationChoice = null;
            do
            {
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
                        car.ShowDetails();
                        car.ShowEngine();
                        break;
                    case 2:
                        car.Accelerate();
                        break;
                    case 3:
                        car.Deaccelerate();
                        break;
                    case 4:
                        car.Stop();
                        Console.WriteLine("Vehicle Stopped");
                        break;
                    case 5:
                        if (car.isMoving())
                            Console.WriteLine("Moving");
                        else
                            Console.WriteLine("Stopped");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.WriteLine("Do you want to perform another operation om this vehicle?(Yes/No)");
                operationChoice = Console.ReadLine();
            } while (string.Compare(operationChoice, "Yes") == 0);
        }
    }

    public void TruckCase()
    {
        Console.WriteLine("Enter Details of the vehicle in the orde: Capacity, Make, Year Of Manufacture, Model, Speed");
        Truck truck = new Truck(int.Parse(Console.ReadLine()));
        string operationChoice = null;
        do
        {
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
                    truck.ShowDetails();
                    truck.ShowCapacity();
                    break;
                case 2:
                    truck.Accelerate();
                    Console.WriteLine("Vehicle Accelerated");
                    break;
                case 3:
                    truck.Deaccelerate();
                    break;
                case 4:
                    truck.Stop();
                    Console.WriteLine("Vehicle Stopped");
                    break;
                case 5:
                    if (truck.isMoving())
                        Console.WriteLine("Moving");
                    else
                        Console.WriteLine("Stopped");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine("Do you want to perform another operation om this vehicle?(Yes/No)");
            operationChoice = Console.ReadLine();
        } while (string.Compare(operationChoice, "Yes") == 0);
    }
}