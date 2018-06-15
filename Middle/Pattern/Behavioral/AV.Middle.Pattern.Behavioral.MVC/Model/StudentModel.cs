using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.MVC.Model
{
    public class StudentModel
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string rollNumber;

		public string RollNumber
		{
			get { return rollNumber; }
			set { rollNumber = value; }
		}
	}
}
