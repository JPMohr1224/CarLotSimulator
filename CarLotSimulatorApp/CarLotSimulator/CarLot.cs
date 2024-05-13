using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
	public class CarLot
	{

        public static int _NumberOfCars;
		

        public List<Car> UsedCars { get; set; } = new List<Car>();

		public void CarsForSale()
		{


            int i = 0;

            foreach (var Car in UsedCars)
			{
				

                Console.WriteLine(Car.Make);
				Console.WriteLine(Car.Model);
				Console.WriteLine(Car.Year);
				i++;
				_NumberOfCars = i;
				

                Console.WriteLine($"How many cars on the lot : {_NumberOfCars}");
			};
		}
    }
}

