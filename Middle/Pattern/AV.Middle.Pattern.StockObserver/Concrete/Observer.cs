using AV.Middle.Pattern.StockObserver.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Pattern.StockObserver.Concrete
{
	public class Observer : IObserver
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public string ObserverName { get; private set; }

		public Observer(string observerName) => ObserverName = observerName;

		public void Update() => logger.Info($"{ObserverName} : A new product has arrived at the store.");
	}
}
