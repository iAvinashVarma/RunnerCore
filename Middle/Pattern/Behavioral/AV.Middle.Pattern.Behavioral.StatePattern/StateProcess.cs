using AV.Middle.Pattern.Behavioral.StatePattern.Concrete;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.Behavioral.StatePattern
{
	/// <summary>
	/// In State pattern a class behavior changes based on its state. This type of design pattern comes under behavior pattern. In State pattern, we create objects which represent various states and a context object whose behavior varies as its state object changes.
	/// </summary>
	public class StateProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var context = new Context();
			var startState = new StartState();
			startState.DoAction(context);
			logger.Info($"{context.State.ToString()}");
		}

		public bool Validate() => true;
	}
}
