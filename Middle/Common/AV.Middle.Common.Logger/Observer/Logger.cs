using AV.Middle.Extension.Generic;
using System;
using System.Collections.Generic;

namespace AV.Middle.Common.Logger.Observer
{
	public class Logger
	{
		private static volatile Logger instance = null;
		private static readonly object mutex = new Object();
		private List<ILogger> _loggers = null;

		private Logger() => _loggers = new List<ILogger>();

		public static Logger Instance
		{
			get
			{
				if (instance == null)
				{
					lock (mutex)
					{
						if (instance == null)
						{
							instance = new Logger();
						}
					}
				}
				return instance;
			}
		}

		public void RegisterObservers(ILogger logger)
		{
			if (!_loggers.Contains(logger))
				_loggers.Add(logger);
		}


		public void RegisterObservers(HashSet<ILogger> loggers) => loggers.ForEach(x => _loggers.Add(x));

		public void LogMessage(string message, bool isTimeStamp = false) => _loggers.ForEach(x => x.LogMessage(isTimeStamp ? $"{DateTime.Now.ToString()} - {message}" : message));
	}
}