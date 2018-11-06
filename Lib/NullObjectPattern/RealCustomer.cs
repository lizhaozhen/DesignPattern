using System;

namespace Lib.NullObjectPattern
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            Name = name;
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}
