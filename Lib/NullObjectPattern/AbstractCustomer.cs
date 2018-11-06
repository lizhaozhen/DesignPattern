using System;

namespace Lib.NullObjectPattern
{
    public abstract class AbstractCustomer
    {
        public string Name { get; set; }
        public abstract bool IsNull();
    }
}
