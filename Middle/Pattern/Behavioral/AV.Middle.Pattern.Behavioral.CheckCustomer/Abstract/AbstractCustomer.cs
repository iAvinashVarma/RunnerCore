using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.CheckCustomer.Abstract
{
    public abstract class AbstractCustomer
    {
		private string name;

		public string Name
		{
			get { return name; }
			protected set { name = value; }
		}

		public abstract bool IsNull();

		public abstract string GetName();
	}
}
