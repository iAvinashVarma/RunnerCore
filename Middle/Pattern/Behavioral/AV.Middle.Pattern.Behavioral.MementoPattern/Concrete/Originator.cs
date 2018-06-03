using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.MementoPattern.Concrete
{
    public class Originator
    {
		private string _state;

		public string State
		{
			get => _state;
			set => _state = value;
		}

		public void SetState(string state) => _state = state;

		public Memento SaveStateToMemento() => new Memento(_state);

		public void GetStateFromMemento(Memento memento) => _state = memento.State;
	}
}
