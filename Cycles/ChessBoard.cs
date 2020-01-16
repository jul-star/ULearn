using System;
using System.Collections.Generic;
using System.Text;

namespace Cycles
{
    public class ChessBoard
    {
        public static void WriteBoard(int size)
        {
           Console.WriteLine(GetBoard(size));
        }

        public static string GetBoard(int size)
        {
            string result = "";
            for (int r = 0; r < size; r++)
            {
                string f;
                string s;
                if (r % 2 == 0)
                {
                    f = "#";
                    s = ".";
                }
                else
                {
                    f = ".";
                    s = "#";
                }

                string line = "";
                for (int c = 0; c < size; c++)
                {
                    if (c % 2 == 0)
                    {
                        line += f;
                    }
                    else
                    {
                        line += s;
                    }
                }

                result += line;
                result += "\n";
            }

            return result;
        }

    }
}
