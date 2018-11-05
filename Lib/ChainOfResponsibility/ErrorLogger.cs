using System;

namespace Lib.ChainOfResponsibility
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level) : base(level)
        {
        }

        protected override void Write(string message)
        {
            // Write error message
        }
    }
}
