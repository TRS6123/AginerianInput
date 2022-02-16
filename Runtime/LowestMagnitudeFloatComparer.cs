using System;
using System.Collections.Generic;

namespace Aginerian.Input
{
    public struct LowestMagnitudeFloatComparer : IComparer<float>
    {
        public int Compare(float x, float y)
        {
            float lenx = Math.Abs(x);
            float leny = Math.Abs(y);
            if (lenx < leny)
                return 1;
            if (lenx > leny)
                return -1;
            return 0;
        }
    }
}
