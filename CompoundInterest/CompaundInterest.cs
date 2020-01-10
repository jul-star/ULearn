using System;
using System.Globalization;
using System.Xml.Schema;

namespace CompoundInterest
{
    public class Balance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input data:");
            string inp = ReadConsole();
            double balance = Calculate(inp);
            Console.WriteLine("Balance: "+balance);
        }

        public static string ReadConsole()
        {
            string res = System.Console.ReadLine();
            return res;
        }
        public static double Calculate(string userInput)
        {
           Tuple<double, double, int> vals = ConvertStringToValues(userInput);
           double result = Total(vals.Item1, vals.Item2, vals.Item3);
           return result;
        }

        public static Tuple<double,double,int> ConvertStringToValues(string userInput)
        {
            string[] values = userInput.Split(' ');
            //NumberStyles styles = NumberStyles.AllowDecimalPoint;
            //IFormatProvider provider = CultureInfo.CreateSpecificCulture("us-US");

            if (!Double.TryParse(values[0], out double val))
            {
                throw new Exception("Can't parse input Value");
            }
            if (!Double.TryParse(values[1], out double interest))
            {
                throw new Exception("Can't parse input Interest");
            }

            if (!Int32.TryParse(values[2], out int months))
            {
                throw new Exception("Can't parse input Months");
            }
            Tuple<double, double, int> res = new Tuple<double, double, int>(val, interest, months);
            return res;
        }

        public static double Total(double val, double interest, int months)
        {
            if (months == 0)
            {
                return val;
            }
            else if (months == 1)
            {
                return Interest(val, interest);
            }

            double newVal = Interest(val, interest);
            return Total(newVal, interest, --months);
        }

        private static double Interest(double val, double interest)
        {
            return val * (interest / 12.0/100.0 + 1.0);
        }
    }
}
