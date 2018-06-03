using AV.Middle.Pattern.Behavioral.StatePattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.StatePattern.Concrete
{
    public class Context
    {
		private IState _state;

		public IState State
		{
			get { return _state; }
			set { _state = value; }
		}

		public Context() => _state = null;
    }
}
