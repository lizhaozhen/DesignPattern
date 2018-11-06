using System;

namespace Lib.VisitorPattern
{
    public interface IComputerPartVisitor
    {
        void Visit(Keyboard keyboard);
    }
}
