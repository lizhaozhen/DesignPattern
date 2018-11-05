using System;

namespace Lib.ChainOfResponsibility
{
    public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        protected int Level {get;set;}
        protected AbstractLogger NextLogger {get;set;}

        protected AbstractLogger(int level)
        {
            Level = level;
        }

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            NextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if(this.Level <= level)
            {
                Write(message);
            }

            if(NextLogger != null)
            {
                NextLogger.LogMessage(level, message);
            }
        }

        abstract protected void Write(string message);
    }
}
