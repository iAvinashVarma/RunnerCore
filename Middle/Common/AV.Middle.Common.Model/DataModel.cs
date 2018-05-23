using System;

namespace AV.Middle.Common.Model
{
	public class DataModel
	{
		private string message;

		public string Message
		{
			get { return message; }
			set { message = value; }
		}

		private DateTime receivedTime;

		public DateTime ReceivedTime
		{
			get { return receivedTime; }
			set { receivedTime = value; }
		}
	}
}