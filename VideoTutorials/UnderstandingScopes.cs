using System;

namespace UnderstandingScope
{
	class MainClass
	{
		private static string k = "";

		public static void Main (string[] args)
		{
			string j = "";
			for (int i = 0; i < 10; i++) 
			{
				j = i.ToString();
				k = i.ToString();
				Console.WriteLine (i);
			}
			Console.WriteLine ("outside the loop: {0}", j);
			Kvalue();
		}

		static void Kvalue()
		{
			Console.WriteLine ("Value of K from Kvalue method (outside main method): {0}", k);
		}
	}
}
