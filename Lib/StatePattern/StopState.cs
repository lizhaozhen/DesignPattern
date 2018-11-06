using System;

namespace Lib.StatePattern
{
    public class StopState : IState
    {
        public void DoAction(Context context)
        {
            // this is a stop state
            context.State = this;
        }
    }
}
