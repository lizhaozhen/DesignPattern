using System;

namespace Lib.ChainOfResponsibility
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level) : base(level)
        {
        }

        protected override void Write(string message)
        {
            // console wirte message
        }
    }
}
