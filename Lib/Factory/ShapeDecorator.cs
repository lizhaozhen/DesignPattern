using System;

namespace Lib.Factory
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape DecoratedShape;

        public ShapeDecorator(IShape decoratedShape)
        {
            DecoratedShape = decoratedShape;
        }

        public virtual string Draw()
        {
            return DecoratedShape.Draw();
        }
    }
}
