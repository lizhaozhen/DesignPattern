using System;

namespace Lib.Bridge
{
    public abstract class Shape
    {
        protected IDraw _draw;

        protected Shape(IDraw draw)
        {
            _draw = draw;
        }

        public abstract string Draw();
    }
}
