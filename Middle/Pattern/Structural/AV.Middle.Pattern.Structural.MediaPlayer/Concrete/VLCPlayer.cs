using AV.Middle.Pattern.Structural.MediaPlayer.Interface;
using log4net;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.MediaPlayer.Concrete
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