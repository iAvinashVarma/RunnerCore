using AV.Middle.Pattern.Behavioral.IteratorPattern.Concrete;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.Behavioral.IteratorPattern
{
	/// <summary>
	/// Behavioral design pattern: Iterator pattern is very commonly used design pattern in Java and .Net programming environment. This pattern is used to get a way to access the elements of a collection object in sequential manner without any need to know its underlying representation.
	/// </summary>
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
			for (var s = iterator.FirstItem; !iterator.IsDone; s = iterator.NextItem)
				logger.Info(s);
		}

		public bool Validate()
		{
			return true;
		}
	}
}
