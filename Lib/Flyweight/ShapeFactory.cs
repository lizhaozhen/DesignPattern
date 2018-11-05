using System;
using System.Collections.Generic;
using Lib.Factory;

namespace Lib.Flyweight
{
    public class ShapeFactory
    {
        private static readonly Dictionary<string, IShape> ShapeDict = new Dictionary<string, IShape>();

        public static IShape GetShape(string shape)
        {
            if(ShapeDict.ContainsKey(shape)) return ShapeDict[shape];

            IShape res = null;
            if(shape == "Circle")
            {
                res = new Circle();
            }

            if(res != null)
            {
                ShapeDict[shape] = res;
            }
            return res;
        }
    }
}
