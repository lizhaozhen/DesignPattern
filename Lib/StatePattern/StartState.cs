using System;

namespace Lib.StatePattern
{
    public class StartState : IState
    {
        public void DoAction(Context context)
        {
            context.State = this;
        }
    }
}
