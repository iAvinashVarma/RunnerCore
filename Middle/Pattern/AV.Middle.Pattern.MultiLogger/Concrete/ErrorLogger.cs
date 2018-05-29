using AV.Middle.Pattern.MultiLogger.Abstract;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.MultiLogger.Concrete
{
	public class ErrorLogger : AbstractLogger
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		private new int _level;

		public ErrorLogger(int level)
		{
			_level = level;
		}

		public override void Write(string message)
		{
			logger.Info($"Error Logger => Write() => Message: {message}.");
		}
	}
}