using System;
using System.Data;

namespace Arrays
{
    public class TicTacToes
    {
        public enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        public enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw
        }

        public static void Main()
        {
            Run("XXX OO. ...");
            Run("OXO XO. .XO");
            Run("OXO XOX OX.");
            Run("XOX OXO OXO");
            Run("... ... ...");
            Run("XXX OOO ...");
            Run("XOO XOO XX.");
            Run(".O. XO. XOX");
        }

        public static void Run(string description)
        {
            Console.WriteLine(description.Replace(" ", Environment.NewLine));
            Console.WriteLine(GetGameResult(CreateFromString(description)));
            Console.WriteLine();
        }

        public static Mark[,] CreateFromString(string str)
        {
            var field = str.Split(' ');
            var ans = new Mark[3, 3];
            for (int x = 0; x < field.Length; x++)
                for (var y = 0; y < field.Length; y++)
                    ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
            return ans;
        }
        public static GameResult GetGameResult(Mark[,] field)
        {
            GameResult[] rows = CheckRows(field);
            GameResult[] columns = CheckColumns(field);
            GameResult[] diagonals = CheckDiagonals(field);
            return Compare(rows, columns, diagonals);
        }

        public static GameResult Compare(GameResult[] rows,
                                        GameResult[] columns,
                                        GameResult[] diagonals)
        {
            int sumCross = 0; 
            int sumCircle = 0;
            for (int i = 0; i < 3; i++)
            {
                sumCross += Sum (rows, columns, diagonals, i, GameResult.CrossWin);
                sumCircle += Sum (rows, columns, diagonals, i, GameResult.CircleWin);
            }

            if (sumCircle > sumCross)
            {
                return GameResult.CircleWin;
            }

            if (sumCircle < sumCross)
            {
                return GameResult.CrossWin;
            }
            return GameResult.Draw;
        }

        private static int Sum(GameResult[] rows, GameResult[] columns, GameResult[] diagonals, int i, GameResult mark)
        {
            if (rows[i] == mark ||
                columns[i] == mark ||
                diagonals[i] == mark)
            {
                return 1;
            }

            return 0;
        }

        public static GameResult[] CheckRows(Mark[,] field)
        {
            GameResult[] results = { GameResult.Draw, GameResult.Draw, GameResult.Draw };
            GameResult[] ar = { GameResult.Draw, GameResult.CrossWin, GameResult.CircleWin };
            for (int r = 0; r < 3; r++)
            {
                if (field[r, 0] != Mark.Empty && field[r, 0] == field[r, 1] && field[r, 1] == field[r, 2])
                    results[r] = ar[(int)field[r, 0]];
            }
            return results;
        }
        public static GameResult[] CheckColumns(Mark[,] field)
        {
            GameResult[] ar = { GameResult.Draw, GameResult.CrossWin, GameResult.CircleWin };
            GameResult[] results = { GameResult.Draw, GameResult.Draw, GameResult.Draw };
            for (int c = 0; c < 3; c++)
            {
                if (field[0, c] != Mark.Empty && field[0, c] == field[1, c] && field[1, c] == field[2, c])
                    results[c] = ar[(int)field[0, c]];
            }
            return results;
        }

        public static GameResult[] CheckDiagonals(Mark[,] field)
        {
            GameResult[] ar = { GameResult.Draw, GameResult.CrossWin, GameResult.CircleWin };
            GameResult[] results = { GameResult.Draw, GameResult.Draw, GameResult.Draw };
            if (field[0, 0] != Mark.Empty && field[0, 0] == field[1, 1] && field[1, 1] == field[2, 2])
            {
                results[0] = ar[(int)field[1, 1]];
            }
            if (field[1, 1] != Mark.Empty && field[2, 0] == field[1, 1] && field[1, 1] == field[0, 2])
            {
                results[1] = ar[(int)field[1, 1]];
            }
            return results;
        }

        public static GameResult CheckDiagonals(Mark[,] field, Mark item)
        {
            GameResult result = GameResult.Draw;
            return result;
        }
    }
}
