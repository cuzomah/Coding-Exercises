using System;

namespace WorkingWithStrings
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*string myString = "My \"so joyous\" life";
			Console.WriteLine (myString);
			Console.WriteLine ();
			string myLine = "What if a need a \nNew Line?";
			Console.WriteLine (myLine);*/

/*			string myDrive = "The all knowing drive: the c:\\ drive";
	        or this method:
			string myDrive = @"The all knowing drive: the c:\ drive"; 
		     @ cancels out backlash escape operation 
			Console.WriteLine (myDrive);

			Predefined formating techniques

			string myString = String.Format ("{0:C}", 400.25);         
			Console.WriteLine (myString);
			string hugeNumber = String.Format ("{0:N}", 8234535226);
			Console.WriteLine (hugeNumber);
			string percentage = String.Format ("{0:P}", .576);
			Console.WriteLine (percentage);
			A way to create a custom format is below

			string randomNumber = String.Format ("Phone number:{0:(###)###-####}", 3018764321);
			Console.WriteLine (randomNumber);*/

			string favoriteLyric = " That was the summer we learned to love the great outdoors. ";
//			favoriteLyric = favoriteLyric.Substring (6,14);
//			Console.WriteLine (favoriteLyric);
			favoriteLyric = favoriteLyric.Replace (" ", "--");
			Console.WriteLine (favoriteLyric);

			string myString = "  We Real Cool  "; 
			myString = String.Format ("Length of String before: {0}, length after {1}",
				myString.Length, myString.Trim ().Length);
			Console.WriteLine (myString);


//			*More effecient way to concantenate strings, but I don't think monodev has the String builder class*

			StringBuilder myString = new StringBuilder ();

			for (int i = 0; i < 100; i++) 
			{
				myString.Append ("--");
				myString.Append (i);
			}
			Console.WriteLine (myString);
		}
	}
}