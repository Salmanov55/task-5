using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
     class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1km;
        public int CurrentFuel;


       
        public Car(string brand, string model) : base(brand)
        {
            this.Model = model;  
        }
        public Car(string brand, string model, int fuelCapacity) : this(brand, model)
        {
           this.FuelCapacity = fuelCapacity;
        }
        public Car(string brand, string model, int fuelCapacity, int fuelFor1km) : this(brand, model, fuelCapacity)
        {
            this.FuelFor1km = fuelFor1km;
        }
        public Car(string brand, string model, int fuelCapacity, double fuelFor1km, double currentFuel) : this(brand, model, fuelCapacity, fuelFor1km)
        {
            CurrentFuel = currentFuel;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{ Year} {Color} {Brand} {Model} {FuelCapacity} {FuelFor1km} {CurrentFuel}");
        }
        double fuel = 0;
        double km = 100;
        double fuelCapacity = 74;

        public void  Drive(double km)
        {
            double roadFuel = km * FuelFor1km;
            if(CurrentFuel > roadFuel)
            {
                double restofFuel=CurrentFuel - roadFuel;
                Console.WriteLine(restofFuel);

            }
            else
            {
                Console.WriteLine("masini");
            }
            
        }

    }
}
