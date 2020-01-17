// В этом пространстве имен содержатся средства для работы с изображениями. 
// Чтобы оно стало доступно, в проект был подключен Reference на сборку System.Drawing.dll

using System;
using System.Drawing;

namespace Fractals
{
    internal static class DragonFractalTask
    {
        private static double s45 = Math.Sin(Math.PI / 4.0);
        private static double c45 = Math.Cos(Math.PI / 4.0);
        private static double s135 = Math.Sin(135.0 * Math.PI / 180.0);
        private static double c135 = Math.Cos(135.0 * Math.PI / 180.0);
        private static double sqrt = Math.Sqrt(2.0);

        public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
        {
            var random = new Random(seed);
            double x = 1.0;
            double y = 0.0;
            double x1, y1;
            for (int i = 0; i < iterationsCount; i++)
            {
                var nextNumber = random.Next(10);
                if (nextNumber % 2 == 0)
                {
                    x1 = (x * c45 - y * s45) / sqrt;
                    y1 = (x * s45 + y * c45) / sqrt;
                }
                else
                {
                    x1 = (x * c135 - y * s135) / sqrt + 1;
                    y1 = (x * s135 + y * c135) / sqrt;
                }

                x = x1;
                y = y1;
                pixels.SetPixel(x, y);
            }
        }
    }
}