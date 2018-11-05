using System;

namespace Lib.Proxy
{
    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk(fileName);
        }

        public void Display()
        {
            // Display file name
        }

        private void LoadFromDisk(string fileName)
        {
            // load from disk;
        }
    }
}
