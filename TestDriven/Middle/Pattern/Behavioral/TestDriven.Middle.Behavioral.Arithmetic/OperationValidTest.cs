using AV.Middle.Pattern.Behavioral.Arithmetic.Concrete;
using AV.Middle.Pattern.Behavioral.Arithmetic.Concrete.Operation;
using AV.Middle.Pattern.Behavioral.Arithmetic.Helper;
using AV.Middle.Pattern.Behavioral.Arithmetic.Interface;
using AV.Middle.Pattern.Behavioral.Arithmetic.Model;
using NUnit.Framework;
using System;

namespace TestDriven.Middle.Behavioral.Arithmetic
{
    [TestFixture]
    public class OperationValidTest
	{
		StrategyHelper helper = null;

		public OperationValidTest() => helper = new StrategyHelper();

		[Test]
		public void AdditionTest()
		{
			// Create instance to test.
			var add = new Add();
			// Define a test input and output value.
			var expected = 3 + 5;
			var number = new Number { NumberOne = 3, NumberTwo = 5 };
			// Run the method under test.
			var actual = add.DoOperation(number);
			// Verify the result.
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void AdditionThrowsOverflowExceptionTest()
		{
			// Create instance to test.
			var add = new Add();
			// Define a test input and output value.
			var number = new Number { NumberOne = int.MaxValue, NumberTwo = int.MaxValue };
			// Run the test and verify the result.
			Assert.Throws<OverflowException>(() => add.DoOperation(number));
		}

		[Test]
        public void AdditionStrategyTest()
        {
			// Create instance to test.
			var add = new Add();
			var context = new Context(add);
			// Define a test input and output value.
			var expected = 3 + 5;
			var number = new Number { NumberOne = 3, NumberTwo = 5 };
			// Run the method under test.
			var actual = helper.DoStrategy(context, number);
			// Verify the result.
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplicationTest()
		{
			// Create instance to test.
			var multiply = new Multiply();
			// Define a test input and output value.
			var expected = 3 * 6;
			var number = new Number { NumberOne = 3, NumberTwo = 6 };
			// Run the method under test.
			var actual = multiply.DoOperation(number);
			// Verify the result.
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void MultiplicationThrowsOverflowExceptionTest()
		{
			// Create instance to test.
			var multiply = new Multiply();
			// Define a test input and output value.
			var number = new Number { NumberOne = int.MaxValue, NumberTwo = int.MaxValue };
			// Run the method under test and verify.
			Assert.Throws<OverflowException>(() => multiply.DoOperation(number));
		}

		[Test]
		public void MultiplicationStrategyTest()
		{
			// Create instance to test.
			var multiply = new Multiply();
			var context = new Context(multiply);
			// Define a test input and output value.
			var expected = 3 * 6;
			var number = new Number { NumberOne = 3, NumberTwo = 6 };
			// Run the method under test.
			var actual = helper.DoStrategy(context, number);
			// Verify the result.
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void SubstractionTest()
		{
			// Create instance to test.
			var subtract = new Substract();
			// Define a test input and output value.
			var expected = 4 - 10;
			var number = new Number { NumberOne = 4, NumberTwo = 10 };
			// Run the method under test.
			var actual = subtract.DoOperation(number);
			// Verify the result.
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void SubstractionThrowsOverflowExceptionTest()
		{
			// Create instance to test.
			var substract = new Substract();
			// Define a test input and output value.
			var number = new Number { NumberOne = int.MaxValue, NumberTwo = int.MinValue };
			// Run the method under test.
			Assert.Throws<OverflowException>(() => substract.DoOperation(number));
		}

		[Test]
		public void SubstractionStrategyTest()
		{
			// Create instance to test.
			var subtract = new Substract();
			var context = new Context(subtract);
			// Define a test input and output value.
			var expected = 4 - 10;
			var number = new Number { NumberOne = 4, NumberTwo = 10 };
			// Run the method under test.
			var actual = helper.DoStrategy(context, number);
			// Verify the result.
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DivisionTest()
		{
			// Create instance to test.
			var divide = new Divide();
			// Define a test input and output value.
			var expected = 10/4;
			var number = new Number { NumberOne = 10, NumberTwo = 4 };
			// Run the method under test.
			var actual = divide.DoOperation(number);
			// Verify the result.
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DivisionThrowsOverflowExceptionTest()
		{
			// Create instance to test.
			var divide = new Divide();
			// Define a test input and output value.
			var number = new Number { NumberOne = int.MaxValue, NumberTwo = 0 };
			// Run the method under test.
			Assert.Throws<DivideByZeroException>(() => divide.DoOperation(number));
		}

		[Test]
		public void DivisionStrategyTest()
		{
			// Create instance to test.
			var divide = new Divide();
			var context = new Context(divide);
			// Define a test input and output value.
			var expected = 10/4;
			var number = new Number { NumberOne =10, NumberTwo = 4 };
			// Run the method under test.
			var actual = helper.DoStrategy(context, number);
			// Verify the result.
			Assert.AreEqual(expected, actual);
		}
	}
}
