using AV.Middle.Pattern.StockObserver.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.StockObserver.Concrete
{
	public class Subject : ISubject
	{
		private List<IObserver> observers = new List<IObserver>();

		private int _inventory;

		public int Inventory
		{
			get => _inventory;
			set
			{
				if (value > _inventory)
					Notify();
				_inventory = value;
			}
		}

		public void Notify() =>	observers.ForEach(x => x.Update());

		public void Subscribe(IObserver observer) => observers.Add(observer);

		public void Unsubscribe(IObserver observer) => observers.Remove(observer);
	}
}
