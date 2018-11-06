using System;

namespace Lib.StrategyPattern
{
    public class OperationSubstract : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return a - b;
        }
    }
}
