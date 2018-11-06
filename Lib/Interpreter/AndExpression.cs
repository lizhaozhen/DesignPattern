using System;

namespace Lib.Interpreter
{
    public class AndExpression : IExpression
    {
        private readonly IExpression expr1;
        private readonly IExpression expr2;

        public AndExpression(IExpression expr1, IExpression expr2)
        {
            this.expr1 = expr1;
            this.expr2 = expr2;
        }

        public bool Interpret(string context)
        {
            return expr1.Interpret(context) && expr2.Interpret(context);
        }
    }
}
