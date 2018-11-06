using System;

namespace Lib.Iterator
{
    public interface IContainer
    {
        IIterator GetIterator();
    }
}
