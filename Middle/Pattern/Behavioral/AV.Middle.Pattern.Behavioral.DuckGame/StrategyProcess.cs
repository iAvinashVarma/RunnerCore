﻿using AV.Middle.Pattern.Behavioral.DuckGame.Behavior;
using AV.Middle.Pattern.Behavioral.DuckGame.Concrete;
using AV.Middle.Pattern.Behavioral.DuckGame.Context;
using AV.Middle.Reflector.IService;
using log4net;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.Behavioral.DuckGame
{
	/// <summary>
	/// Behavior Design Pattern: In Strategy pattern, a class behavior or its algorithm can be changed at run time. This type of design pattern comes under behavior pattern.
	/// </summary>
	public class StrategyProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			logger.Info("Mallard Duck:");
			DuckHelper(new MallardDuck());

			logger.Info("Spaniel Duck:");
			DuckHelper(new SpanielDuck());

			logger.Info("Customized Duck:");
			var customizedDuck = new MallardDuck();
			customizedDuck.SetFly(new FlyHigh());
			DuckHelper(new MallardDuck());
		}

		public bool Validate()
		{
			return true;
		}

		private void DuckHelper(DuckContext duckContext)
		{
			duckContext.DoFly();
			duckContext.DoQuack();
			duckContext.DoSwim();
		}
	}
}