using System;

namespace DatesAndTimes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DateTime myValue = DateTime.Now;
			/*Below is the use of a bunch of different methods within the DateTime class.
			 *They Can be very useful for printing out any a time or date in any specific manner.*/

			//Console.WriteLine (myValue.ToString ());
			//Console.WriteLine(myValue.ToShortDateString());
			//Console.WriteLine(myValue.ToShortTimeString());
			//Console.WriteLine(myValue.ToLongDateString());
			//Console.WriteLine(myValue.ToLongTimeString());

			//Console.WriteLine (myValue.AddDays (3).ToLongDateString ());
			//Console.WriteLine (myValue.Month);

			//Below is the use of the TimeSpan class to figure out how long I've been alive

			//DateTime myBirthday = new DateTime (2002, 4, 3);
			//Console.WriteLine (myBirthday.ToLongDateString ());

			DateTime myBirthday = DateTime.Parse("4/3/2002");
			TimeSpan myAge = DateTime.Now.Subtract (myBirthday);
			Console.WriteLine ("I've been alive for {0} days", myAge.TotalDays);
			Console.WriteLine ("I have also been alive for {0} years", myAge.TotalDays / 365);

		}
	}
}
