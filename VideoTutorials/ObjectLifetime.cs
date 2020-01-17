using System;

namespace ObjectLifetime
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Car myCar = new Car ();
			/*myCar.Make = "Bugatti";
			myCar.Model = "Highballer";
			myCar.Year = 2018;
			myCar.Color = "Crimson";*/

			Car myOtherCar;
			myOtherCar = myCar; // Adding another access point to the same specific space in memory

			Console.WriteLine ("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, 
				myOtherCar.Year, myOtherCar.Color); //proving that their the same access point

			myOtherCar = null; // Removes this access point to the specific space in memory

			Car myBestCar = new Car ("Toyota", "Camry", 2012, "Royal Blue");
			Car.MyMethod ();


		}
	}

	class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }

		public Car ()
		{
			Make = "Toyota";
		}

		public Car(string make, string model, int year, string color) // Constructor
		{
			Make = make;
			Model = model;
			Year = year;
			Color = color;
		}

		public static void MyMethod()
		{
			Console.WriteLine("This is a static method");
		}
	}
}
