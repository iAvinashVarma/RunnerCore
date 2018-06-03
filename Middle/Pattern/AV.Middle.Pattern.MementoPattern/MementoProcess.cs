using AV.Middle.Pattern.MementoPattern.Concrete;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.MementoPattern
{
	/// <summary>
	/// Behavioral design pattern: Memento pattern is used to restore state of an object to a previous state. Memento pattern falls under behavioral pattern category.
	/// </summary>
	public class MementoProcess : IProcess
    {
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var originator = new Originator();
			var careTaker = new CareTaker();
			originator.SetState("State #1");
			originator.SetState("State #2");
			careTaker.Add(originator.SaveStateToMemento());

			originator.SetState("State #3");
			careTaker.Add(originator.SaveStateToMemento());

			originator.SetState("State #4");
			logger.Info($"Current State: {originator.State}.");

			originator.GetStateFromMemento(careTaker.Get(0));
			logger.Info($"First Saved State: {originator.State}.");
			originator.GetStateFromMemento(careTaker.Get(1));
			logger.Info($"Second Saved State: {originator.State}.");
		}

		public bool Validate() => true;
	}
}
