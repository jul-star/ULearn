using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Cycles;

namespace MyXUnitTests
{
    public class ChessBoardTest
    {
        [Fact]
        public static void Test_1()
        {
            string actual = ChessBoard.GetBoard(1);
            string expected = "#\n";
            Assert.Equal(expected, actual);
        }
        [Fact]
        public static void Test_2()
        {
            string actual = ChessBoard.GetBoard(2);
            string expected = "#.\n.#\n";
            Assert.Equal(expected, actual);
        }
    }
}
