using AV.Middle.Pattern.Structural.MediaPlayer.Concrete;
using AV.Middle.Pattern.Structural.MediaPlayer.Interface;
using System;

namespace AV.Middle.Pattern.Structural.MediaPlayer.Adapter
{
	public class MediaAdapter : IPlayer
	{
		private IAdvancedPlayer advancedPlayer;

		public MediaAdapter(string audioType)
		{
			if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
			{
				advancedPlayer = new VLCPlayer();
			}
			else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
			{
				advancedPlayer = new MP4Player();
			}
		}

		public void Play(string audioType, string fileName)
		{
			if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
			{
				advancedPlayer.PlayVLC(fileName);
			}
			else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
			{
				advancedPlayer.PlayMP4(fileName);
			}
		}
	}
}