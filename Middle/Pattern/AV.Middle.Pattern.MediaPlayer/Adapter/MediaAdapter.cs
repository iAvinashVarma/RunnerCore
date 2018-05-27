using AV.Middle.Pattern.MediaPlayer.Concrete;
using AV.Middle.Pattern.MediaPlayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.MediaPlayer.Adapter
{
	public class MediaAdapter : IPlayer
	{
		IAdvancedPlayer advancedPlayer;

		public MediaAdapter(string audioType)
		{
			if(audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
			{
				advancedPlayer = new VLCPlayer();
			}
			else if(audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
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
