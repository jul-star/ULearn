using System;

namespace _01_01_Hello_World
{
    class Sample3
    {
        static void Main(string[] args)
        {
            Mixed();
        }
        static string who = "class";

        static void Mixed()
        {
            //Console.Write(who + " ");
            string who = "Mixed";
            Console.Write(who);
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Hello World!");
        //    //int a = (int) Math.Round(34.34);
        //    //    Console.WriteLine("a "+a);
        //    //TestGetGreetingMessage();
        //    //Print(GetSquare(42));
        //    TestGetLastHalf();
        //}


        /// <summary>
        /// Вычисляет и округляет
        /// </summary>
        /// <param name="a">Первый аргумент</param>
        /// <param name="b">Второй аргумент</param>
        /// <returns></returns>
        public static int DivedeAndRound(double a, double b)
        {
            return (int) Math.Round(a / b);
        }

        public static void TestGetGreetingMessage()
        {
            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
        }

        private static string GetGreetingMessage(string name, double salary)
        {
            // возвращает "Hello, <name>, your salary is <salary>"
            int _salary = (int)Math.Ceiling(salary);
            FormattableString fs = $"Hello, {name}, your salary is {_salary}";

            string _out = fs.ToString();
            return _out;
        }

        public static void Print(int a)
        {
            Console.WriteLine(a);
        }

        public static int GetSquare(int a)
        {
            return a * a;
        }

        static void TestGetLastHalf()
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }

        static string GetLastHalf(string text)
        {
            string tmp = text.Substring(text.Length / 2);
            string res = tmp.Replace(" ",  string.Empty);
            return res;
        }
    }
}



