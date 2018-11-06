using System;

namespace Lib.VisitorPattern
{
    public class Keyboard : IComputerPart
    {
        public void Accept(IComputerPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
