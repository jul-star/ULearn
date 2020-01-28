using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            string name = "Юлиан";
            int days = 30;
            int months = 12;
            //  X — число месяца, по Y — номер месяца
            string[] xLabels = InitArray(days,1);
            string[] yValues = InitArray(months);
            double[,] heat = InitHeat(days, months);
            
            foreach (var val in names)
            {
                    if (val.BirthDate.Day != 1 && val.Name.ToLower() == name.ToLower())
                    {
                        ++heat[val.BirthDate.Day-2, val.BirthDate.Month-1];
                    }
            }

            return new HeatmapData(
                string.Format("Пример карты интенсивностей {0}", name),
                heat,
                xLabels,
                yValues);
        }

        private static double[,] InitHeat(int days, int months)
        {
            double[,] heat = new double[days,months];
            for (int i = 0; i < days; i++)
            {
                for (int j = 0; j < months; j++)
                {
                    heat[i, j] = 0.0;
                }
            }

            return heat;
        }

        private static string[] InitArray(int size, int offset=0)
        {
            string[] arr = new string[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = (i + 1+ offset).ToString();
            }

            return arr;
        }
    }
}