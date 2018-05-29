using AV.Middle.Pattern.MultiLogger.Abstract;
using AV.Middle.Pattern.MultiLogger.Concrete;
using AV.Middle.Reflector.IService;
using System.Collections;

namespace AV.Middle.Pattern.MultiLogger
{
	public class ChainProcess : IProcess
	{
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var chainOfLoggers = GetChainOfLoggers();
			chainOfLoggers.LogMessage(AbstractLogger.INFO, "This is an information.");
			chainOfLoggers.LogMessage(AbstractLogger.DEBUG, "This is an debug level information.");
			chainOfLoggers.LogMessage(AbstractLogger.ERROR, "This is an error information.");
		}

		public bool Validate()
		{
			return true;
		}

		private AbstractLogger GetChainOfLoggers()
		{
			var errorLogger = new ErrorLogger(AbstractLogger.ERROR);
			var fileLogger = new FileLogger(AbstractLogger.DEBUG);
			var consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

			errorLogger.SetLogger(fileLogger);
			fileLogger.SetLogger(consoleLogger);
			return errorLogger;
		}
	}
}