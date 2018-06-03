using AV.Middle.Pattern.Behavioral.StockObserver.Concrete;
using AV.Middle.Reflector.IService;
using System;
using System.Collections;

namespace AV.Middle.Pattern.Behavioral.StockObserver
{
	/// <summary>
	/// Behavioral design pattern: In State pattern a class behavior changes based on its state. This type of design pattern comes under behavior pattern. In State pattern, we create objects which represent various states and a context object whose behavior varies as its state object changes.
	/// </summary>
	public class ObserverProcess : IProcess
	{
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var subject = new Subject();
			var observerOne = new Observer("AVI");
			subject.Subscribe(observerOne);
			subject.Subscribe(new Observer("MAN"));
			subject.Inventory++;
			subject.Unsubscribe(observerOne);
			subject.Subscribe(new Observer("PRU"));
			subject.Inventory++;
		}

		public bool Validate() => true;
	}
}
