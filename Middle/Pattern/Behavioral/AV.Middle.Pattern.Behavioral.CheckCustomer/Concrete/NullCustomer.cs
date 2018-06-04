using AV.Middle.Pattern.Behavioral.CheckCustomer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.CheckCustomer.Concrete
{
	public class NullCustomer : AbstractCustomer
	{
		public override string GetName() => "Not available in Customer Database";

		public override bool IsNull() => true;
	}
}
