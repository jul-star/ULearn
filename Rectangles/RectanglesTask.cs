using System;

namespace Rectangles
{
    public static class RectanglesTask
    {
        // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
        public static bool AreIntersected(Rectangle r1, Rectangle r2)
        {
            return r1.Left <= r2.Right && r1.Right >= r2.Left &&
                   r1.Top <= r2.Bottom && r1.Bottom >= r2.Top;
        }

        // Площадь пересечения прямоугольников
        public static int IntersectionSquare(Rectangle r1, Rectangle r2)
        {
            if (AreIntersected(r1, r2))
            {
                int dX = DeltaX(r1, r2);
                int dY = DeltaY(r1, r2);
                return dX * dY;
            }
            return 0;
        }

        public static int DeltaX(Rectangle r1, Rectangle r2)
        {
            if (r1.Left >= r2.Left && r1.Right <= r2.Right) // r1 in r2
                return r1.Right - r1.Left;

            if (r2.Left >= r1.Left && r2.Right <= r1.Right) // r2 in r1
                return r2.Right - r2.Left;

            if (r1.Left <= r2.Left && r1.Right <= r2.Right) // r1 left on r2
                return r1.Right - r2.Left;

            if (r1.Left >= r2.Left && r1.Right >= r2.Right) // r1 right to r2
                return r2.Right - r1.Left;
            return 0;
        }
        public static int DeltaY(Rectangle r1, Rectangle r2)
        {
            if (r1.Top >= r2.Top && r1.Bottom <= r2.Bottom) // r1 in r2
                return r1.Bottom - r1.Top;
            if (r2.Top >= r1.Top && r2.Bottom <= r1.Bottom) // r2 in r1
                return r2.Bottom - r2.Top;
            if (r1.Top <= r2.Top && r1.Bottom <= r2.Bottom) // r1 above r2
                return r1.Bottom - r2.Top;
            if (r1.Top >= r2.Top && r1.Bottom >= r2.Bottom) // r1 under r2
                return r2.Bottom - r1.Top;

            return 0;
        }

        // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
        // Иначе вернуть -1
        // Если прямоугольники совпадают, можно вернуть номер любого из них.
        public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            if (AreInside(r1, r2)) // r1 in r2
            {
                return 0;
            }

            if (AreInside(r2, r1)) //r2 in r1
            {
                return 1;
            }
            return -1;
        }

        public static bool AreInside(Rectangle r1, Rectangle r2)
        {
            return r1.Top >= r2.Top && r1.Bottom <= r2.Bottom
                && r1.Left >= r2.Left && r1.Right <= r2.Right;
        }
    }
}