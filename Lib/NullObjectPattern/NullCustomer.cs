using System;

namespace Lib.NullObjectPattern
{
    public class NullCustomer : AbstractCustomer
    {
        public NullCustomer()
        {
            Name = "Not Available";
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}
