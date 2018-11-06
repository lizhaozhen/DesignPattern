using System;

namespace Lib.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        Object Next();
    }
}
