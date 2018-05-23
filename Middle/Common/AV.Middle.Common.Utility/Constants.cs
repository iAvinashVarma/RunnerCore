using System;

namespace AV.Middle.Common.Utility
{
	public class Constants
	{
		#region Default Path

		public const string LogDirectory = @"C:\\AVI\\LOGS\\";

		public const string LogPath = LogDirectory + Runner;

		public const string Runner = "Runner";

		#endregion Default Path

		#region Log4Net Related Constants

		public const string AV = "AV";

		public const string HeaderFooterLine = "================================================================";

		public const string DatePattern = "-dd-MM-yyyy'.LOG'";

		public const string LogFileConversionPattern = "%date{HH:mm:ss} - %message%newline";

		public const string EventViewerConversionPattern = "%level [%property{log4net:HostName}] [%date{ISO8601}] [%logger] [%method] [%thread] [%line] [%message] %newline";

		public const string TimeFormat = "HH:mm:ss";

		public const string DefaultValue = "-";

		#endregion Log4Net Related Constants

		public const string Tab = "\t";

		public const string Space = " ";

		public static readonly string Seperator = $"================================================================{Environment.NewLine}";
	}
}