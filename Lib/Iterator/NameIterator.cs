using System;

namespace Lib.Iterator
{
    public class NameIterator : IIterator
    {
        private readonly string[] names;
        private int index;

        public NameIterator(string[] names)
        {
            index = 0;
            this.names = names;
        }

        public bool HasNext()
        {
            return index < names.Length;
        }

        public object Next()
        {
            if(HasNext()) return names[index++];
            return null;
        }
    }
}
