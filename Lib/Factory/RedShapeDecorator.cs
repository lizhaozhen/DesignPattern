using System;

namespace Lib.Factory
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {
        }

        public override string Draw()
        {
            var res = DecoratedShape.Draw();
            SetRedBorder(DecoratedShape);
            return res;
        }

        private void SetRedBorder(IShape decoratedShape)
        {
            // set red border
        }
    }
}
