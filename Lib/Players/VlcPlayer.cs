using System;

namespace Lib.Players
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file. Name: "+ fileName);
        }
    }
}
