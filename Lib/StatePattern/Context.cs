using System;

namespace Lib.StatePattern
{
    public class Context
    {
        public Context()
        {
            State = null;
        }

        public IState State { get; set; }
    }
}
