using System.Collections.Generic;
using NUnit.Framework;
using ClassLibrary1;
using FluentAssertions;

namespace UnitTests
{
	[TestFixture]
    public class NumberTests
	{

		private INumbersExercise _numbersExercise;
		private NumberObject _numberObject;
		
	    [Test]
		[Category("FirstNumberAndWord")]
	    public void FirstNumberAndPhrase()
	    {

			_numberObject = new NumberObject { FirstNumber = 3, FirstWord = "Dev", SecondNumber = 5, SecondWord = "Test" };
		    _numbersExercise = new NumberExercise(_numberObject);

		    for (var i = 1; i <= 20; i++)
		    {
			    var firstValues = new List<int> {3, 6, 9, 12, 18};
				var retVal = _numbersExercise.PrintNumbers(i);
			    if (firstValues.Contains(i))
			    {
				    retVal.Should().Be("Dev");
			    }
			}
	    }

		[Test]
		[Category("FirstNumberAndWord")]
		public void FirstNumberAndPhrase_NumbersOnly()
		{
			_numberObject = new NumberObject { FirstNumber = 3, FirstWord = "Dev", SecondNumber = 5, SecondWord = "Test" };
			_numbersExercise = new NumberExercise(_numberObject);

			for (var i = 1; i <= 20; i++)
			{
				var firstValues = new List<int> { 1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19 };
				var retVal = _numbersExercise.PrintNumbers(i);
				if (firstValues.Contains(i))
				{
					retVal.Should().Be(i.ToString());
				}
			}
		}

		[Test]
		[Category("SecondNumberAndWord")]
		public void SecondNumberAndPhrase()
	    {
		    _numberObject = new NumberObject { FirstNumber = 3, FirstWord = "Dev", SecondNumber = 5, SecondWord = "Test" };
			_numbersExercise = new NumberExercise(_numberObject);

		    for (var i = 1; i <= 20; i++)
		    {
			    var secondValues = new List<int> {5,10,20};
			    var retVal = _numbersExercise.PrintNumbers(i);
			    if (secondValues.Contains(i))
			    {
				    retVal.Should().Be("Test");
			    }
			}

		}

		[Test]
		[Category("SecondNumberAndWord")]
		public void SecondNumberAndPhrase_NumbersOnly()
		{
			_numberObject = new NumberObject { FirstNumber = 3, FirstWord = "Dev", SecondNumber = 5, SecondWord = "Test" };
			_numbersExercise = new NumberExercise(_numberObject);

			for (var i = 1; i <= 20; i++)
			{
				var secondValues = new List<int> { 1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19 };
				var retVal = _numbersExercise.PrintNumbers(i);
				if (secondValues.Contains(i))
				{
					retVal.Should().Be(i.ToString());
				}
			}
		}

		[Test]
		[Category("AllNumbersAndWords")]
	    public void BothNumbersAndPhrase()
	    {
		    _numberObject = new NumberObject { FirstNumber = 3, FirstWord = "Dev", SecondNumber = 5, SecondWord = "Test" };
			_numbersExercise = new NumberExercise(_numberObject);

		    for (var i = 1; i <= 20; i++)
		    {
			    var allValues = new List<int> { 15 };
			    var retVal = _numbersExercise.PrintNumbers(i);
			    if (allValues.Contains(i))
			    {
				    retVal.Should().Be("DevTest");
			    }
			}
		}

		[Test]
		[Category("AllNumbersAndWords")]
		public void BothNumbersAndPhrase_NumbersOnly()
		{
			_numberObject = new NumberObject { FirstNumber = 3, FirstWord = "Dev", SecondNumber = 5, SecondWord = "Test" };
			_numbersExercise = new NumberExercise(_numberObject);

			for (var i = 1; i <= 20; i++)
			{
				var allValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 17, 18, 19, 20 };
				var retVal = _numbersExercise.PrintNumbers(i);
				if (allValues.Contains(i))
				{
					// Just showing another way of asserting
					retVal.Should().NotBe("DevTest");
				}
			}
		}
	}
}
