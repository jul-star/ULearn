using System;

namespace Branching
{
    /// <summary>
    /// год, номер которого кратен 400 — високосный;
    /// остальные года, номера которых кратны 100 — невисокосные;
    /// остальные года, номера которых кратны 4 — високосные.
    /// </summary>
    public class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year %100 !=0);
        }
    }
}
