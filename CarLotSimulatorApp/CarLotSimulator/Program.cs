﻿using System;

namespace CarLotSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            
            Car carVinOne = new Car() { Make = "Toyota", Model = "Corolla", Year = 2007, IsDrivable = true, HonkNoise = "Beeeep", EngineNoise = "Vroom"};
            Console.WriteLine($"How many cars on the lot : {CarLot._numberOfCars}");
            Car carVinTwo = new Car() { Make = "Ford", Model = "Bronco", Year = 2025, IsDrivable = true, HonkNoise = "HONK", EngineNoise = "vrrrr" };
            Console.WriteLine($"How many cars on the lot : {CarLot._numberOfCars}");
            Car carVinThree = new Car() { Make = "Jeep", Model = "Wrangler", Year = 2012, IsDrivable = true, HonkNoise = "Beee-beeeep", EngineNoise = "chuf chuf purr" };
            Console.WriteLine($"How many cars on the lot : {CarLot._numberOfCars}");

            /*
            carVinOne.MakeEngineNoise();
            carVinOne.MakeHonkNoise();

            carVinTwo.MakeEngineNoise();
            carVinTwo.MakeHonkNoise();

            carVinThree.MakeEngineNoise();
            carVinThree.MakeHonkNoise();

            */

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //Car carVinOne = new Car() { Make = "Toyota", Model = "Corolla", Year = 2007, IsDrivable = true, HonkNoise = "Beeeep", EngineNoise = "Vroom" };
            //Car carVinTwo = new Car() 
            /*carVinTwo.Make = "Ford";
             * carVinTwo.Model = "Bronco";
             * carVinTwo.Year = 2025;
             * carVinTwo.IsDrivable = true;
             * carVinTwo.HonkNoise = "HONK";
             * carVinTwo.EngineNoise = "vrrrr";
             */

            //Custon Constructor in Car.cs


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            var Cars4You = new CarLot();
            
            Cars4You.UsedCars.Add(carVinOne);
            
            Cars4You.UsedCars.Add(carVinTwo);
            
            Cars4You.UsedCars.Add(carVinThree);
            

            Cars4You.CarsForSale();
        }

           
       

    }
}
