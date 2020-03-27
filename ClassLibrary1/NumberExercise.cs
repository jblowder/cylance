namespace ClassLibrary1
{
	public class NumberExercise : INumbersExercise
	{

		public NumberObject Values;

		public NumberExercise(NumberObject exerciseValues)
		{
			Values = exerciseValues;
		}

		public string PrintNumbers(int i)
		{

			if (i % Values.FirstNumber == 0 && i % Values.SecondNumber == 0)
			{
				return Values.FirstWord+Values.SecondWord;
					
			}
			if (i % Values.FirstNumber == 0)
			{
				return Values.FirstWord;
					
			}
			if (i % Values.SecondNumber == 0)
			{
				return Values.SecondWord;
					
			}

			return i.ToString();
			
		}
	}

}
