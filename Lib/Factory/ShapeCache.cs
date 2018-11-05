using System;
using System.Collections.Generic;

namespace Lib.Factory
{
    public class ShapeCache
    {
        private static Dictionary<string, IShape> shapeDic = new Dictionary<string, IShape>();

        public static void LoadCache()
        {
            shapeDic["Circle"] = new Circle();
            shapeDic["Square"] = new Square();
            shapeDic["Rectangle"] = new Rectangle();
        }

        public static IShape GetShape(string typeName)
        {
            var shape = shapeDic[typeName];
            return shape;
        }
    }
}
