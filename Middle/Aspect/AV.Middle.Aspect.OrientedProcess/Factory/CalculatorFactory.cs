using AV.Middle.Aspect.OrientedProcess.Concrete;
using AV.Middle.Aspect.OrientedProcess.Interface;
using log4net;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AV.Middle.Aspect.OrientedProcess.Factory
{
    public class CalculatorFactory
    {
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public ICalculator<T> Create<T>(CreateType createType = CreateType.DynamicProxy)
		{
			ICalculator<T> calculator = null;
			switch (createType)
			{
				case CreateType.DynamicProxy:
					calculator = new DynamicProxy<ICalculator<T>>().Create(new Calculator<T>(),
						s => logger.Info($"{s}"),
						e => logger.Error($"{e}"),
						o => o?.ToString(),
						TaskScheduler.Current);
					break;
				case CreateType.LoggerRepository:
					calculator = new Calculator<T>();
					break;
			}
			return calculator;
		}
	}
}
