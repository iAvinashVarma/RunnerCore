using AV.Middle.Pattern.Behavioral.Arithmetic.Concrete;
using AV.Middle.Pattern.Behavioral.Arithmetic.Concrete.Operation;
using AV.Middle.Pattern.Behavioral.Arithmetic.Helper;
using AV.Middle.Pattern.Behavioral.Arithmetic.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDriven.Middle.Behavioral.Arithmetic
{
	[TestFixture]
	public class OperationInvalidTest
    {
		StrategyHelper helper = null;

		public OperationInvalidTest() => helper = new StrategyHelper();

		[Test]
		public void AdditionNotEqualTest()
		{
			// Create instance to test.
			var add = new Add();
			// Define a test input and output value.
			var expected = 3 + 6;
			var number = new Number { NumberOne = 3, NumberTwo = 5 };
			// Run the method under test.
			var actual = add.DoOperation(number);
			// Verify the result.
			Assert.AreNotEqual(expected, actual);
		}

		[Test]
		public void AdditionStrategyNotEqualTest()
		{
			// Create instance to test.
			var add = new Add();
			var context = new Context(add);
			// Define a test input and output value.
			var expected = 3 + 6;
			var number = new Number { NumberOne = 3, NumberTwo = 5 };
			// Run the method under test.
			var actual = helper.DoStrategy(context, number);
			// Verify the result.
			Assert.AreNotEqual(expected, actual);
		}

		[Test]
		public void MultiplicationNotEqualTest()
		{
			// Create instance to test.
			var multiply = new Multiply();
			// Define a test input and output value.
			var expected = 3 * 5;
			var number = new Number { NumberOne = 3, NumberTwo = 6 };
			// Run the method under test.
			var actual = multiply.DoOperation(number);
			// Verify the result.
			Assert.AreNotEqual(expected, actual);
		}

		[Test]
		public void MultiplicationStrategyNotEqualTest()
		{
			// Create instance to test.
			var multiply = new Multiply();
			var context = new Context(multiply);
			// Define a test input and output value.
			var expected = 3 * 5;
			var number = new Number { NumberOne = 3, NumberTwo = 6 };
			// Run the method under test.
			var actual = helper.DoStrategy(context, number);
			// Verify the result.
			Assert.AreNotEqual(expected, actual);
		}

		[Test]
		public void SubstractionNotEqualTest()
		{
			// Create instance to test.
			var subtract = new Substract();
			// Define a test input and output value.
			var expected = 4 - 9;
			var number = new Number { NumberOne = 4, NumberTwo = 10 };
			// Run the method under test.
			var actual = subtract.DoOperation(number);
			// Verify the result.
			Assert.AreNotEqual(expected, actual);
		}

		[Test]
		public void SubstractionStrategyNotEqualTest()
		{
			// Create instance to test.
			var subtract = new Substract();
			var context = new Context(subtract);
			// Define a test input and output value.
			var expected = 4 - 9;
			var number = new Number { NumberOne = 4, NumberTwo = 10 };
			// Run the method under test.
			var actual = helper.DoStrategy(context, number);
			// Verify the result.
			Assert.AreNotEqual(expected, actual);
		}

		[Test]
		public void DivisionNotEqualTest()
		{
			// Create instance to test.
			var divide = new Divide();
			// Define a test input and output value.
			var expected = 10 / 6;
			var number = new Number { NumberOne = 10, NumberTwo = 4 };
			// Run the method under test.
			var actual = divide.DoOperation(number);
			// Verify the result.
			Assert.AreNotEqual(expected, actual);
		}

		[Test]
		public void DivisionStrategyNotEqualTest()
		{
			// Create instance to test.
			var divide = new Divide();
			var context = new Context(divide);
			// Define a test input and output value.
			var expected = 10 / 6;
			var number = new Number { NumberOne = 10, NumberTwo = 4 };
			// Run the method under test.
			var actual = helper.DoStrategy(context, number);
			// Verify the result.
			Assert.AreNotEqual(expected, actual);
		}
	}
}
