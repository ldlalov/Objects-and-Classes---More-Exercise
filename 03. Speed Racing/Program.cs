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
            this.cars = new List<Car>();
        }
        public List<Car> cars { get; set; }

        public string Model { get; set; }   
        public double FuelAmount  { get; set; }   
        public double FuelConsumation  { get; set; }   
        public double distance  { get; set; }   

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumation = double.Parse(input[2]);
                Car car = new Car(model, fuelAmount,fuelConsumation);
                Car.cars.Add(car);
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmd = command.Split(' ');
                string model = cmd[1];
                double distance = double.Parse(cmd[2]);
            }

        }
    }
}
