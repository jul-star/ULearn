using System;
using System.Collections.Generic;
using System.Text;

namespace Branching
{
    public class Mediana
    {
        public static int MiddleOf0(int a, int b, int c)
        {
            List<int> list = new List<int>{a,b,c};
            list.Sort();
            return list[1];
        }

        public static int MiddleOf(int a, int b, int c)
        {
            if (a > b)
            {
                int tmp = b;
                b = a;
                a = tmp;
            }

            if (b > c)
            {
                b = c;
            }

            if (a > b)
            {
                b = a;
            }

            return b;

        }

    }
}
