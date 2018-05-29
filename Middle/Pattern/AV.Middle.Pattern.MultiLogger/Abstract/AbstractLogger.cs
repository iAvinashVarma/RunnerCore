namespace AV.Middle.Pattern.MultiLogger.Abstract
{
	public abstract class AbstractLogger
	{
		public const int INFO = 1;
		public const int DEBUG = 2;
		public const int ERROR = 3;

		protected int _level;
		protected AbstractLogger _abstractLogger;

		public void SetLogger(AbstractLogger abstractLogger)
		{
			_abstractLogger = abstractLogger;
		}

		public void LogMessage(int level, string message)
		{
			if (_level <= level)
			{
				Write(message);
			}
			if (_abstractLogger != null)
			{
				_abstractLogger.LogMessage(level, message);
			}
		}

		public abstract void Write(string message);
	}
}