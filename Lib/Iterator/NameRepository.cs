using System;

namespace Lib.Iterator
{
    public class NameRepository : IContainer
    {
        public string[] Names = {"A", "B", "C", "D"};

        public IIterator GetIterator()
        {
            throw new NotImplementedException();
        }
    }
}
