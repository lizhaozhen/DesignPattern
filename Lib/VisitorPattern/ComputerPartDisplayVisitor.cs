using System;

namespace Lib.VisitorPattern
{
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void Visit(Keyboard keyboard)
        {
            // Display keyboard
        }
    }
}
