using AV.Middle.Pattern.Structural.MediaPlayer.Adapter;
using AV.Middle.Pattern.Structural.MediaPlayer.Interface;
using log4net;
using System;
using System.Reflection;

namespace AV.Middle.Pattern.Structural.MediaPlayer.Concrete
{
	public class AudioPlayer : IPlayer
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		private MediaAdapter mediaAdapter;

		public void Play(string audioType, string fileName)
		{
			// In built support to play MP3 music files.
			if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
			{
				logger.Info($"Playing {audioType} file. FileName: {fileName}.");
			}
			else if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase) || audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
			{
				logger.Info($"Playing {audioType} file. FileName: {fileName}.");
				mediaAdapter = new MediaAdapter(audioType);
				mediaAdapter.Play(audioType, fileName);
			}
			else
			{
				logger.Warn($"Invalid media type {audioType}, format not supported.");
			}
		}
	}
}