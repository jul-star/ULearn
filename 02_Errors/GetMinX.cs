using System;

namespace _02_Errors
{
    public class MinX
    {
        public static void Main()
        {
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));

            // А в этих случаях решение существует:
            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
        }

        public static string GetMinX(int a, int b, int c)
        {
            if (a > 0)
            {
                double db = Convert.ToDouble(-b);
                double da = Convert.ToDouble(a);
                double res = db / 2.0 / da;
                return res.ToString();
            }
            else if (a == 0 && b == 0)
            {
                return c.ToString();
            }
            else
            {
                return "Impossible";
            }
        }



    }
}
