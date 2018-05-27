using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.MediaPlayer.Interface
{
    public interface IAdvancedPlayer
    {
		void PlayVLC(string fileName);

		void PlayMP4(string fileName);
    }
}
