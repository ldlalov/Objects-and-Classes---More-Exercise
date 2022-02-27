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
        public Car(string model, int engineSpeed, int enginePower, int cargoWieght, string cargoType)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
            this.CargoWeight = cargoWieght;
            this.CargoType = cargoType;
            Model = model;

        }
        public string Model { get; set; }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
        public List<Car> Cars { get; set; }
    }
    class Engine
    {
        public Engine()
        {
            this.Engines = new List<Engine>();
        }
        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public List<Engine> Engines { get; set; }
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
                Engine currEngine = new Engine(engineSpeed,enginePower);
                engine.Engines.Add(currEngine);
                Cargo currCargo = new Cargo(cargoWeight,cargoType);
                cargo.Cargos.Add(currCargo);
                Car currenCar = new Car(model, currEngine.EngineSpeed,currEngine.EnginePower,currCargo.CargoWeight,currCargo.CargoType);
                car.Cars.Add(currenCar);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<Car> fragile = new List<Car>();
                foreach (Car item in car.Cars)
                {
                    if (item.CargoType == "fragile" && item.CargoWeight < 1000)
                    {
                        fragile.Add(item);
                    }
                }
                foreach(Car item in fragile)
                {
                Console.WriteLine($"{item.Model}");
                }
            }

            if (command == "flamable")
            {
                List<Car> flamable = new List<Car>();
                foreach (Car item in car.Cars)
                {
                    if (item.CargoType == "flamable" && item.EnginePower > 250)
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
