using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{

			CarLot._numberOfCars++;

        }
        public string Make { get; set; }
		public string Model { get; set; }
		public int Year;
      
		
        public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDrivable { get; set; }
       
		public void MakeEngineNoise() { Console.WriteLine(EngineNoise); }
		public void MakeHonkNoise() { Console.WriteLine(HonkNoise); }
       



		//Custom Constructor for Bonus
		public Car(string make, string model, int year)
		{
			Make = "Toyota";
			Model = "Corolla";
			Year = 2007;
		}

	}
}
