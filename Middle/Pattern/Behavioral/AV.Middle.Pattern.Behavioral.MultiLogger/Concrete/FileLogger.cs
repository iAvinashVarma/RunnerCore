using AV.Middle.Pattern.Behavioral.MultiLogger.Abstract;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Behavioral.MultiLogger.Concrete
{
	public class FileLogger : AbstractLogger
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		private new int _level;

		public FileLogger(int level)
		{
			_level = level;
		}

		public override void Write(string message)
		{
			logger.Info($"File Logger => Write() => Message: {message}.");
		}
	}
}