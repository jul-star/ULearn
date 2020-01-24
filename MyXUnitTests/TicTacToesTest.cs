using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Arrays;

namespace MyXUnitTests
{
    public class TicTacToesTest
    {
        [Fact]
        public static void TestRun_Row()
        {
            string description = "XXX OO. ...";
            TicTacToes.Mark[,] vMark = TicTacToes.CreateFromString(description);
            TicTacToes.GameResult vExpected = TicTacToes.GameResult.CrossWin;
            TicTacToes.GameResult vActual = TicTacToes.GetGameResult(vMark);
            Assert.Equal(vExpected, vActual);
        }
        [Fact]
        public static void TestRun_Draw()
        {
            string[] ds =
            {
                "XXX OOO ..."
            };
            TicTacToes.GameResult[] vExpecteds =
            {
                TicTacToes.GameResult.Draw
            };
            for (int i = 0; i < ds.Length; i++)
            {
                TicTacToes.Mark[,] vMark = TicTacToes.CreateFromString(ds[i]);
                TicTacToes.GameResult vActual = TicTacToes.GetGameResult(vMark);
                Assert.Equal(vExpecteds[i], vActual);
            }
        }

        [Fact]
        public static void TestRun_Diagonal()
        {
            string[] ds =
            {
                "OXO XOX OX."
            };
            TicTacToes.GameResult[] vExpecteds =
            {
                TicTacToes.GameResult.CircleWin,
            };
            for (int i = 0; i < ds.Length; i++)
            {
                TicTacToes.Mark[,] vMark = TicTacToes.CreateFromString(ds[i]);
                TicTacToes.GameResult vActual = TicTacToes.GetGameResult(vMark);
                Assert.True(vExpecteds[i] == vActual, i.ToString());
            }
        }

        [Fact]
        public static void TestRun_All()
        {
            string[] ds =
            {
                "XXX OO. ...",
                "OXO XO. .XO",
                "OXO XOX OX.",
                "XOX OXO OXO",
                "... ... ...",
                "XXX OOO ...",
                "XOO XOO XX.",
                ".O. XO. XOX"
            };
            TicTacToes.GameResult[] vExpecteds =
            {
                TicTacToes.GameResult.CrossWin,
                TicTacToes.GameResult.CircleWin,
                TicTacToes.GameResult.CircleWin,
                TicTacToes.GameResult.Draw,
                TicTacToes.GameResult.Draw,
                TicTacToes.GameResult.Draw,
                TicTacToes.GameResult.CrossWin,
                TicTacToes.GameResult.CircleWin
        };
            for (int i = 0; i < ds.Length; i++)
            {
                TicTacToes.Mark[,] vMark = TicTacToes.CreateFromString(ds[i]);
                TicTacToes.GameResult vActual = TicTacToes.GetGameResult(vMark);
                Assert.True(vExpecteds[i] == vActual, i.ToString());
            }
        }
    }
}
