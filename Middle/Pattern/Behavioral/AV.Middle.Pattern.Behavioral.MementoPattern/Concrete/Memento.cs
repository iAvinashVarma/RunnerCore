using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.MementoPattern.Concrete
{
    public class Memento
    {
		private string _state;

		public Memento(string state) => _state = state;

		public string State
		{
			get => _state;
			set => _state = value;
		}
	}
}
