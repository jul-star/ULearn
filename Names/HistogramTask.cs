using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {

            int lowerBorder = 0;
            int upperBorder = 31;

            string[] xLabels = new string[upperBorder];
            double[] yValues = new double[upperBorder];
            int[] frequency = new int[upperBorder];
            int count = 0;
            for (int i = lowerBorder; i < upperBorder; i++)
            {
                xLabels[i] = (i+1).ToString();
                yValues[i] = 0;
                frequency[i] = 0;
            }

            foreach (var val in names)
            {
                if (val.Name == name)
                {
                    if (val.BirthDate.Day != 1)
                    {
                        ++frequency[val.BirthDate.Day-1];
                        ++count;
                    }
                }
            }

            for (int i = lowerBorder; i < upperBorder; i++)
            {
                yValues[i] = (double)(frequency[i]) /(double)count;
            }

            string title = string.Format("Рождаемость людей с именем '{0}'", name);
            HistogramData hd = new HistogramData(title, xLabels, yValues);
            return hd;
        }
    }
}