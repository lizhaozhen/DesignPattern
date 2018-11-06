using System;

namespace Lib.Interpreter
{
    public class TerminalExpression : IExpression
    {
        private readonly string data;

        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool Interpret(string context)
        {
            return context.Contains(data);
        }
    }
}
