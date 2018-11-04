using System;

namespace Lib.Players
{
    public class AudioPlayer : IMediaPlayer
    {
        public void Play(string audioType, string fileName)
        {
            if(audioType == "mp3")
            {
                // play mp3
            }
            else if(audioType == "vlc" || audioType == "mp4")
            {
                var adapter = new MediaAdapter(audioType);
                adapter.Play(audioType, fileName);
            }
        }
    }
}
