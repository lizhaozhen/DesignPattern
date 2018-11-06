using System;

namespace Lib.StrategyPattern
{
    public class OperationAdd : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return a + b;
        }
    }
}
