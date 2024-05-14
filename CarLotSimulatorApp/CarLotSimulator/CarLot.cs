using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
	public class CarLot
	{

        public static int _numberOfCars;


        public List<Car> UsedCars { get; set; } = new List<Car>();

		public void CarsForSale()
		{


            

            foreach (var Car in UsedCars)
			{
				

                Console.WriteLine(Car.Make);
				Console.WriteLine(Car.Model);
				Console.WriteLine(Car.Year);
            




                
			};
		}
    }
}

