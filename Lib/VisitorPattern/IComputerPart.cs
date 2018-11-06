using System;

namespace Lib.VisitorPattern
{
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor visitor);
    }
}
