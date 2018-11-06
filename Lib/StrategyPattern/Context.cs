using System;

namespace Lib.StrategyPattern
{
    public class Context
    {
        private readonly IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return strategy.DoOperation(a, b);
        }
    }
}
