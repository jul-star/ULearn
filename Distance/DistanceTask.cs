using System;

namespace DistanceTask
{
    public static class DistanceTask
    {
        // Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            double r1 = dist(x, y, ax, ay);
            double r2 = dist(x, y, bx, by);
            double r12 = dist(ax, ay, bx, by);
            if (r1 >= dist(r2, r12, 0, 0))
            {
                return r2;
            }
            else if (r2 >= dist(r1, r12, 0, 0))
            {
                return r1;
            }
            else
            {
                double a = by - ay;
                double b = ax - bx;
                double c = -ax * (by - ay) + ay * (bx - ax);
                double t = dist(a, b, 0, 0);
                if (c > 0)
                {
                    a = -a;
                    b = -b;
                    c = -c;
                }
                double r0 = (a * x + b * y + c) / t;
                return Math.Abs(r0);
            }
        }

        public static double dist(double ax, double ay, double bx, double by)
        {
            return Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
        }


    }
}