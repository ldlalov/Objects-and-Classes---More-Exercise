using System;
using System.Collections.Generic;

namespace _04._Raw_Data
{
    class Car
    {

        public Car()
        {
            this.Cars = new List<Car>();

        }
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;

        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Car> Cars { get; set; }
    }
    class Engine
    {
        public Engine()
        {

        }
        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    class Cargo
    {
        public Cargo()
        {
            this.Cargos = new List<Cargo>();
        }
        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }
        public List<Cargo> Cargos { get; set; }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Car car = new Car();
            Engine engine = new Engine();
            Cargo cargo = new Cargo();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Engine currEngine = new Engine(engineSpeed, enginePower);
                Cargo currCargo = new Cargo(cargoWeight, cargoType);
                cargo.Cargos.Add(currCargo);
                Car currenCar = new Car(model, currEngine, currCargo);
                car.Cars.Add(currenCar);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<Car> fragile = new List<Car>();
                foreach (Car item in car.Cars)
                {
                    if (item.Cargo.CargoType == "fragile" && item.Cargo.CargoWeight < 1000)
                    {
                        fragile.Add(item);
                    }
                }
                foreach (Car item in fragile)
                {
                    Console.WriteLine($"{item.Model}");
                }
            }

            if (command == "flamable")
            {
                List<Car> flamable = new List<Car>();
                foreach (Car item in car.Cars)
                {
                    if (item.Cargo.CargoType == "flamable" && item.Engine.EnginePower > 250)
                    {
                        flamable.Add(item);
                    }
                }
                foreach (Car item in flamable)
                {
                    Console.WriteLine($"{item.Model}");
                }
            }
        }
    }
}
