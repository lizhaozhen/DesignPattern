using System;

namespace Lib.Players
{
    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer _mediaPlayer;

        public MediaAdapter(string audioType)
        {
            if(audioType == "vlc") _mediaPlayer = new VlcPlayer();
            else if(audioType == "mp4") _mediaPlayer = new Mp4Player();
        }

        public void Play(string audioType, string fileName)
        {
            if(audioType == "vlc") _mediaPlayer.PlayVlc(fileName);
            else if(audioType == "mp4") _mediaPlayer.PlayMp4(fileName);
        }
    }
}
