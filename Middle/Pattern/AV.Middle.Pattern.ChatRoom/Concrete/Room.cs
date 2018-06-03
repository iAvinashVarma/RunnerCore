using AV.Middle.Pattern.ChatRoom.Model;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Pattern.ChatRoom.Concrete
{
    public class Room
    {
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void ShowMessage(User user, string message)
		{
			logger.Info($"{DateTime.Now} [{user.Name}] : {message}.");
		}
    }
}
