using System;
using ClassLibrary1;

namespace ConsoleApp1
{
	public class Program
	{
		private int _upperValue;

		private static void Main()
		{
			var p = new Program();
			p.NumberExercise();
		}

		public void NumberExercise()
		{
			// Create a new instance of the object being passed to library
			var numObject = new NumberObject();
			
			// Request input from user for upper bounds value, and perform error checking
			do
			{
				Console.Write("Please enter your upper value (as a whole integer), or press enter for 100:");
				var response = Console.ReadLine();

				if (string.IsNullOrEmpty(response))
				{
					_upperValue = 100;
					break; 
				}

				// Only check the right side if it's actually a number
				if (!Int32.TryParse(response, out var number) || Convert.ToInt32(response) == 0)
				{
					Console.WriteLine("Please enter a valid integer!");
				}
				else
				{
					_upperValue = Convert.ToInt32(response);
					break;
				}
				
			} while (true);

			#region FirstNumberAndResponse

			// Request input from user for the first number to be used to divide into each of the numbers from 1 - upper bounds
			do
			{
				Console.Write("Please enter your first divisible number (as a whole integer), or press enter for 3:");
				var response = Console.ReadLine();

				if (string.IsNullOrEmpty(response))
				{
					numObject.FirstNumber = 3;
					break;
				}

				// Only check the right side if it's actually a number
				if (!Int32.TryParse(response, out var number) || Convert.ToInt32(response) == 0)
				{
					Console.WriteLine("Please enter a valid integer!");
				}
				else
				{
					numObject.FirstNumber = Convert.ToInt32(response);
					break;
				}

			} while (true);

			// Request input from user for the phrase to use when the first number is found to be divided into the number
			Console.Write($"Please enter your keyphrase for when a number has been evenly divided by {numObject.FirstNumber} or press enter for \"Fizz\":");
			var firstWord = Console.ReadLine();

			numObject.FirstWord = string.IsNullOrEmpty(firstWord) ? "Fizz" : firstWord;

			#endregion

			#region SecondNumberAndResponse

			// Request input from user for the second number to be used to divide into each of the numbers from 1 - upper bounds
			do
			{
				Console.Write("Please enter your second divisible number (as a whole integer), or press enter for 5:");
				var response = Console.ReadLine();

				if (string.IsNullOrEmpty(response))
				{
					numObject.SecondNumber = 5;
					break;
				}

				// Only check the right side if it's actually a number
				if (!Int32.TryParse(response, out var number) || Convert.ToInt32(response) == 0)
				{
					Console.WriteLine("Please enter a valid integer!");
				}
				else
				{
					numObject.SecondNumber = Convert.ToInt32(response);
					break;
				}

			} while (true);

			// Request input from user for the phrase to use when the second number is found to be divided into the number
			Console.Write($"Please enter your keyphrase for when a number has been evenly divided by {numObject.SecondNumber} or press enter \"Buzz\":");
			var secondWord = Console.ReadLine();

			numObject.SecondWord = string.IsNullOrEmpty(secondWord) ? "Buzz" : secondWord;

			#endregion

			// Create a new instance of the NumberExercise class and pass in the numObject object to it's constructor
			var num = new NumberExercise(numObject);

			for (var i = 1; i <= _upperValue; i++)
			{
				var retVal = num.PrintNumbers(i);
				Console.WriteLine(retVal);
			}

			// Keep console app from exiting before results have been reviewed
			Console.ReadLine();
		}
	}

	
}
