using AV.Middle.Pattern.MediaPlayer.Interface;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Pattern.MediaPlayer.Concrete
{
	public class VLCPlayer : IAdvancedPlayer
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void PlayMP4(string fileName)
		{
			logger.Info($"Playing VLC file. FileName: {fileName}.");
		}

		public void PlayVLC(string fileName)
		{
			// Do nothing.
		}
	}
}
