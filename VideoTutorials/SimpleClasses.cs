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

			Console.WriteLine ("{0} {1} {2} {3}", myCar.Model, myCar.Make, 
				myCar.Year, myCar.Color);
		}
	}

	class Car
	{
		public string Model { get; set; }
		public string Make { get; set; }
		public int Year { get ; set;}
		public string Color { get; set; }
	}
}
