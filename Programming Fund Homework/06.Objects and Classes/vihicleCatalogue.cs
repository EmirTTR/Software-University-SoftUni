using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
      

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="end")
                {
                    break;
                }
                string[] split = input.Split("/");

                string typeOfVehicle = split[0];
                string brand = split[1];
                string model = split[2];
                int PowerOrWeight = int.Parse(split[3]);

                if (typeOfVehicle == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = PowerOrWeight;
                    catalog.Cars.Add(car);

                }
                else if (typeOfVehicle == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = PowerOrWeight;
                    catalog.Trucks.Add(truck);
                }
            }
                if (catalog.Cars.Count>0)
                {
                    Console.WriteLine($"Cars:");
                    foreach (Car carsList in catalog.Cars.OrderBy(car => car.Brand))
                    {
                        Console.WriteLine($"{carsList.Brand}: {carsList.Model} - {carsList.HorsePower}hp");
                    }
                }
                if (catalog.Trucks.Count>0)
                {
                    Console.WriteLine($"Trucks:");
                    foreach (var trucksList in catalog.Trucks.OrderBy(truck=>truck.Brand))
                    {
                        Console.WriteLine($"{trucksList.Brand}: {trucksList.Model} - {trucksList.Weight}kg");
                    }
                }
        }
    }
    class Truck
    {
            public string Brand { get; set; }
            public string Model { get; set; }
            public double Weight { get; set; }
    } 
    class Car
    {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
    }
    class Catalog
    {
       
        public List<Truck> Trucks { get; set; }
       
        public List<Car> Cars { get; set; }

        public Catalog() 
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
}
