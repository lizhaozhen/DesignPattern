using System;

namespace Lib.ObserverPattern
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subjecter subjecter) : base(subjecter)
        {
        }

        public override void Update()
        {
            // Update binary
        }
    }
}
