using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.MementoPattern.Concrete
{
    public class CareTaker
    {
		private List<Memento> mementoList = new List<Memento>();

		public void Add(Memento memento) => mementoList.Add(memento);

		public Memento Get(int index) => mementoList[index];
    }
}
