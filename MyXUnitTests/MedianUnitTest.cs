using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Branching;

namespace MyXUnitTests
{
    public class MedianUnitTest
    {
        [Fact]
        public static void Test()
        {
            List<List<int>> userInput = new List<List<int>>{
                new List<int>{5, 0, 100}, // => 5
                new List<int>{12, 12, 11}, // => 12
                new List<int>{1, 1, 1}, // => 1
                new List<int>{2, 3, 2},
                new List<int>{8, 8, 8},
                new List<int>{5, 0, 1},
            };
            List<int> expected = new List<int>
            {
                5,
                12,
                1,
                2,
                8,
                1
            };
            for (int i = 0; i < userInput.Count; i++)
            {
                (int a, int b, int c) = (userInput[i][0],userInput[i][1],userInput[i][2]);
                int actual = Mediana.MiddleOf(a, b, c);
                int actual0 = Mediana.MiddleOf0(a, b, c);
                Assert.True(expected[i] == actual, "A I: "+i.ToString());
                Assert.True(expected[i] == actual0, "A0 I: "+i.ToString());
            }
        }
    }
}

