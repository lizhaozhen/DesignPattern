using System;

namespace Lib.Players
{
    public interface IAdvancedMediaPlayer
    {
        void PlayVlc(String fileName);
        void PlayMp4(String fileName);
    }
}
