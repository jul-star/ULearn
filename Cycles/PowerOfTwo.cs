using System;

namespace Cycles
{
    public class PowerOfTwo
    {
        public static int GetMinPowerOfTwoLargerThan(int number)
        {
            int res = 1;
            while (res <= number)
            {
                res *= 2;
            }

            return res;
        }
    }
}
