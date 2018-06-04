using AV.Middle.Pattern.Behavioral.CheckCustomer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.CheckCustomer.Concrete
{
    public class RealCustomer : AbstractCustomer
    {
		public RealCustomer(string name) => Name = name;

		public override string GetName() => Name;

		public override bool IsNull() => false;
	}
}
