using System;

namespace Lib.StatePattern
{
    public interface IState
    {
        void DoAction(Context context);
    }
}
