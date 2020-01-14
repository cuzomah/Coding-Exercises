using System;

namespace SimpleClasses
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Car myCar = new Car ();
			myCar.Make = "Bugatti";
			myCar.Model = "Migos Level";
			myCar.Year = 2018;
			myCar.Color = "Navy Blue";
//			Decimal value = DetermineMarketValue (myCar);

			Console.WriteLine ("{0} {1} {2} {3}", myCar.Model, myCar.Make, 
				myCar.Year, myCar.Color);

//			Console.WriteLine ("{0:C}", value);
			Console.WriteLine(myCar.DetermineMarketValue());

		}
//		creating a method to use for the car class in the main class
		private static decimal DetermineMarketValue(Car car)
		{
			decimal carValue = 100.0M;
			return carValue;	
		}

	}

	class Car
	{
//		Everything below is what an object of what this class is instantiated with: 
//		every object in this class has these charcateristics.

		public string Model { get; set; }
		public string Make { get; set; }
		public int Year { get ; set;}
		public string Color { get; set; }

//		Creating the method under car class since information is already here

		public decimal DetermineMarketValue()
		{
			decimal carValue;
			if (Year > 1990)
				carValue = 10000;
			else
				carValue = 2000;
			return carValue;		
		}
	}
}
