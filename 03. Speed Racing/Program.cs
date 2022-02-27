using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Speed_Racing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumation)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumation = fuelConsumation;
        }
        public Car()
        {
            this.CarsList = new List<Car>();
        }
        public List<Car> CarsList { get; set; }
        public string Model { get; set; }   
        public double FuelAmount  { get; set; }   
        public double FuelConsumation  { get; set; }   
        public double Distance  { get; set; }   
        public bool CanPass(double wantedDistance)
        {
            double possibleDistance = FuelAmount / FuelConsumation;
                if (possibleDistance >= wantedDistance)
                {
                return true;
                }
                else
            {
                return false; ;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumation = double.Parse(input[2]);
                Car curentCar = new Car(model, fuelAmount, fuelConsumation);
                car.CarsList.Add(curentCar);
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmd = command.Split(' ');
                string model = cmd[1];
                double distance = double.Parse(cmd[2]);
                foreach (Car item in car.CarsList)
                {
                    if (item.Model == model)
                    {
                        if (item.CanPass(distance))
                        {
                            item.Distance += distance;
                            item.FuelAmount -= distance * item.FuelConsumation;
                        }
                        else
                        {
                            Console.WriteLine("Insufficient fuel for the drive");
                        }
                    }
                }
            }
            foreach (Car item in car.CarsList)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.Distance}");
            }
        }
    }
}
