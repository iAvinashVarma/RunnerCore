using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.MediaPlayer.Interface
{
    public interface IPlayer
    {
		void Play(string audioType, string fileName);
    }
}
