﻿using AV.Middle.Pattern.Behavioral.Arithmetic.Concrete;
using AV.Middle.Pattern.Behavioral.Arithmetic.Concrete.Operation;
using AV.Middle.Pattern.Behavioral.Arithmetic.Interface;
using AV.Middle.Pattern.Behavioral.Arithmetic.Model;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.Behavioral.Arithmetic
{
	/// <summary>
	/// In Strategy pattern, a class behavior or its algorithm can be changed at run time. This type of design pattern comes under behavior pattern.
	/// </summary>
	public class StrategyProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var number = new Number(10, 5);
			logger.Info($"{number.NumberOne} + {number.NumberTwo} = {StrategyHelper(new Context(new Add()), number)}");
			logger.Info($"{number.NumberOne} - {number.NumberTwo} = {StrategyHelper(new Context(new Substract()), number)}");
			logger.Info($"{number.NumberOne} * {number.NumberTwo} = {StrategyHelper(new Context(new Multiply()), number)}");
		}

		private int StrategyHelper(Context context, Number number) => context.ExecuteStrategy(number);

	public bool Validate() => true;
	}
}
