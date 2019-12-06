using System;

namespace WhileIteration
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		// While loop: Checks for a condition in order to keep executing code. Used for when there is
		// no set number of times for a specific loop to repeat.
			bool displayMenu = true;
			while (displayMenu) 
			{
				displayMenu = MainMenu ();
			}
		
		}

		private static bool MainMenu()
		{
			Console.Clear (); //Console.clear clears the screen from before hand once its invoked.
			Console.WriteLine ("Select an Option:");
			Console.WriteLine ("1) Option 1");
			Console.WriteLine ("2) Option 2");
			Console.WriteLine ("3) Exit");

			string choice = Console.ReadLine ();
			if (choice == "1") 
			{
				PrintNumbers ();
				return true; 

			}
			else if (choice == "2") 
			{
				GuessingGame ();
				return true;
			}
			else if (choice == "3") 
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		private static void PrintNumbers()
		{
			Console.Clear ();
			Console.WriteLine ("Print Numbers Game!");
			Console.WriteLine ("Print a number: ");
			int result = int.Parse (Console.ReadLine ());
			int counter = 1;
			while (counter <= result) 
			{
				Console.Write (counter);
				Console.Write ("-");
				counter++;
			}
			Console.ReadLine ();
		}

		private static void GuessingGame()
		{
			Console.Clear ();
			Console.WriteLine ("Guessing Game!");

			Random myRandom = new Random();
			int randomNumber = myRandom.Next(1, 11);
			Console.ReadLine ();
			int guesses = 4;
			bool incorrect = true;
			string result = Console.ReadLine();

			do
			{
				Console.WriteLine("Guess a number between 1 and 10");
				if(result == randomNumber.ToString())
		
					incorrect = !incorrect;
				}
				else
				{
					guesses--;
					Console.WriteLine("Wrong! Guess again!");
				}
			} while(incorrect && guesses > 0);
			
			Console.WriteLine("Correct! you only had {0} guess(es) left.", guesses);
				
		}
	}
}
