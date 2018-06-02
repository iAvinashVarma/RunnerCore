using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Aspect.OrientedProcess.Model
{
    public class Customer
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}
	}
}
