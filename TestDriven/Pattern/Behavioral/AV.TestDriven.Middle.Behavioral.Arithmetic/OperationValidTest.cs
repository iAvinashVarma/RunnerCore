using AV.Middle.Pattern.Behavioral.Arithmetic.Concrete;
using AV.Middle.Pattern.Behavioral.Arithmetic.Concrete.Operation;
using AV.Middle.Pattern.Behavioral.Arithmetic.Helper;
using AV.Middle.Pattern.Behavioral.Arithmetic.Interface;
using AV.Middle.Pattern.Behavioral.Arithmetic.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestDriven.Middle.Behavioral.Arithmetic
{
    [TestClass]
    public class OperationValidTest
	{
		StrategyHelper helper = null;

		public OperationValidTest() => helper = new StrategyHelper();

		[TestMethod]
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
			Assert.AreEqual<int>(expected, actual);
		}

		[TestMethod]
		[ExpectedException(typeof(OverflowException))]
		public void AdditionThrowsOverflowExceptionTest()
		{
			// Create instance to test.
			var add = new Add();
			// Define a test input and output value.
			var number = new Number { NumberOne = int.MaxValue, NumberTwo = int.MaxValue };
			// Run the method under test.
			var actual = add.DoOperation(number);
		}

		[TestMethod]
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
			Assert.AreEqual<int>(expected, actual);
		}

		[TestMethod]
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
			Assert.AreEqual<int>(expected, actual);
		}

		[TestMethod]
		[ExpectedException(typeof(OverflowException))]
		public void MultiplicationThrowsOverflowExceptionTest()
		{
			// Create instance to test.
			var multiply = new Multiply();
			// Define a test input and output value.
			var number = new Number { NumberOne = int.MaxValue, NumberTwo = int.MaxValue };
			// Run the method under test.
			var actual = multiply.DoOperation(number);
		}

		[TestMethod]
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
			Assert.AreEqual<int>(expected, actual);
		}

		[TestMethod]
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
			Assert.AreEqual<int>(expected, actual);
		}

		[TestMethod]
		[ExpectedException(typeof(OverflowException))]
		public void SubstractionThrowsOverflowExceptionTest()
		{
			// Create instance to test.
			var substract = new Substract();
			// Define a test input and output value.
			var number = new Number { NumberOne = int.MaxValue, NumberTwo = int.MinValue };
			// Run the method under test.
			var actual = substract.DoOperation(number);
		}

		[TestMethod]
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
			Assert.AreEqual<int>(expected, actual);
		}

		[TestMethod]
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
			Assert.AreEqual<int>(expected, actual);
		}

		[TestMethod]
		[ExpectedException(typeof(DivideByZeroException))]
		public void DivisionThrowsOverflowExceptionTest()
		{
			// Create instance to test.
			var divide = new Divide();
			// Define a test input and output value.
			var number = new Number { NumberOne = int.MaxValue, NumberTwo = 0 };
			// Run the method under test.
			var actual = divide.DoOperation(number);
		}

		[TestMethod]
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
			Assert.AreEqual<int>(expected, actual);
		}
	}
}
