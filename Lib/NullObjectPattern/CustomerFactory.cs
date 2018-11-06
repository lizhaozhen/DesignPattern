using System;

namespace Lib.NullObjectPattern
{
    public class CustomerFactory
    {
        public static readonly string[] Names = {"A", "B", "C"};

        public static AbstractCustomer GetCustomer(string name)
        {
            foreach(var nameInArr in Names)
            {
                if(nameInArr == name)
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}
