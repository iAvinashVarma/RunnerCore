using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.Arithmetic.Model
{
    public class Number
    {
		private int _numberOne;

		public int NumberOne
		{
			get { return _numberOne; }
			set { _numberOne = value; }
		}

		private int _numberTwo;

		public int NumberTwo
		{
			get { return _numberTwo; }
			set { _numberTwo = value; }
		}

		public Number()
		{

		}

		public Number(int numberOne, int numberTwo)
		{
			_numberOne = numberOne;
			_numberTwo = numberTwo;
		}
	}
}
