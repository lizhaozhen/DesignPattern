using System;

namespace Lib.Interpreter
{
    public interface IExpression
    {
        bool Interpret(string context);
    }
}
