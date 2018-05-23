using System;
using System.Diagnostics;
using System.IO;

namespace AV.Middle.Common.Logger.Observer
{
	public class FileLogger : ILogger
	{
		private string filePath;

		public FileLogger(string fileName) => filePath = fileName;

		public virtual void LogMessage(string message)
		{
			try
			{
				using (var streamWriter = File.AppendText(filePath))
				{
					streamWriter.WriteLine(message);
					streamWriter.Close();
				};
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}
	}
}