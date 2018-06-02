using AV.Middle.Pattern.IteratorPattern.Concrete;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.IteratorPattern
{
	public class IteratorProcess : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var nameAggregator = new NameAggregator();
			nameAggregator[0] = "Avinash";
			nameAggregator[1] = "Varma";

			var iterator = nameAggregator.GetIterator();

			for(var s = iterator.FirstItem; !iterator.IsDone; s = iterator.NextItem)
			{
				logger.Info(s);
			}
		}

		public bool Validate()
		{
			return true;
		}
	}
}
