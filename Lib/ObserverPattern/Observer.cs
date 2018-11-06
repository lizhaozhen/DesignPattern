using System;

namespace Lib.ObserverPattern
{
    public abstract class Observer
    {
        protected Subjecter Subjecter;

        public Observer(Subjecter subjecter)
        {
            this.Subjecter = subjecter;
            this.Subjecter.Attach(this);
        }

        public abstract void Update();
    }
}
