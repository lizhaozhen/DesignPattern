using System;

namespace Lib.ObserverPattern
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subjecter subjecter) : base(subjecter)
        {
        }

        public override void Update()
        {
            // Update hexa
        }
    }
}
