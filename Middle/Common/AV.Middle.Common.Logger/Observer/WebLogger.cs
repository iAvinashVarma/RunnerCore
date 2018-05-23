using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace AV.Middle.Common.Logger.Observer
{
	public class WebLogger : ILogger
	{
		private string webUrl;

		public WebLogger(string webPath) => webUrl = webPath;

		public void LogMessage(string message)
		{
			var finalUrl = $"{webUrl}{message}";
			try
			{
				var request = WebRequest.Create(finalUrl) as HttpWebRequest;
				var response = request.GetResponse() as HttpWebResponse;
				var header = response.Headers;
				using (var streamReader = new StreamReader(response.GetResponseStream(), Encoding.ASCII))
				{
					var responseText = streamReader.ReadToEnd();
				};
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}
	}
}