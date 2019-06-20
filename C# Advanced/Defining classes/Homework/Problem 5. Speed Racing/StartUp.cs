using System;
using System.Collections.Generic;

namespace Problem_5._Speed_Racing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int CarNumber = int.Parse(Console.ReadLine());
            List<Car> Cars = new List<Car>();

            for (int i = 0; i < CarNumber; i++)
            {
                string[] CarsFromConsole = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string CarModel = CarsFromConsole[0];
                double fuelAmount = double.Parse(CarsFromConsole[1]);
                double fuelConsumptionFor1km = double.Parse(CarsFromConsole[2]);
                Cars.Add(new Car(CarModel,fuelAmount,fuelConsumptionFor1km));
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] CommandsFromConsole = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string CarModel = CommandsFromConsole[1];
                int Kilometares = int.Parse(CommandsFromConsole[2]);
                for (int i = 0; i < Cars.Count; i++)
                {
                    if (CarModel==Cars[i].Model)
                    {
                        if (Cars[i].IsTheFuelEnoughf(Kilometares))
                        {
                            Console.WriteLine("Insufficient fuel for the drive");
                        }
                        
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in Cars)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
