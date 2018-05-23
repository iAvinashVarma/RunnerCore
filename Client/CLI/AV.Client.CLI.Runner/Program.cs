using AV.Middle.Common.Configure;

namespace AV.Client.CLI.Runner
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Log.Instance.Configure("log4net.config");
			Runner.Instance.Run(args);
		}
	}
}