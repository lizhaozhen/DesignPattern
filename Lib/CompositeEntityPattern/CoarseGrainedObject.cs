using System;

namespace Lib.CompositeEntityPattern
{
    public class CoarseGrainedObject
    {
        DependentObject1 do1 = new DependentObject1();
        DependentObject2 do2 = new DependentObject2();

        public void SetData(string data1, string data2)
        {
            do1.Data = data1;
            do2.Data = data2;
        }
    }
}
