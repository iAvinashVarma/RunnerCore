using System;
using System.Collections.Generic;

namespace AV.Middle.Common.Logger.Observer
{
	public class Logger
	{
		private static volatile Logger instance = null;
		private static readonly object mutex = new Object();
		private List<ILogger> loggers = null;

		private Logger()
		{
			loggers = new List<ILogger>();
		}

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
			if (!loggers.Contains(logger))
				loggers.Add(logger);
		}

		public void LogMessage(string message, bool isTimeStamp = false)
		{
			foreach (var logger in loggers)
			{
				logger.LogMessage(isTimeStamp ? $"{DateTime.Now.ToString()} - {message}" : message);
			}
		}
	}
}