using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class VehicleCases
{
    public void BicycleCase()
    {
        Console.WriteLine("Enter Details of the vehicle in the orde: No. Of Gears, Make, Year Of Manufacture, Model, Speed");
        Bicycle bicycle = new Bicycle(int.Parse(Console.ReadLine()));
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
                    bicycle.Accelerate();
                    Console.WriteLine("Vehicle Accelerated");
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