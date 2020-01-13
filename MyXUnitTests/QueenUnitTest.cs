using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Branching;

namespace MyXUnitTests
{
    public class QueenUnitTest
    {
        [Fact]
        public static void Test()
        {
            List<List<string>> userInput = new List<List<string>>
            {
               new List<string>{"a1","a1" }, //no move

               new List<string>{"a1","a3" }, // hor
               new List<string>{"b4","b8" },
               new List<string>{"b6","b3" },

               new List<string>{"a1","b1" }, // ver
               new List<string>{"b2","a2" },
               new List<string>{"c2","a2" },

               new List<string>{"c1","a3" },  // diag
               new List<string>{"b2","a3" },
               new List<string>{"b2","c3" },

               new List<string>{"b2","d3" },  // false
               new List<string>{"a1","d2" },  // false
               new List<string>{"d2","b1" },  // false

            };
            List<bool> expected = new List<bool>
            {
                false,

                true,
                true,
                true,

                true,
                true,
                true,

                true,
                true,
                true,

                false,
                false,
                false
            };
            for (int i = 0; i < expected.Count; i++)
            {
                bool actual = Queen.IsCorrectMove(userInput[i][0], userInput[i][1]);
                Assert.True(expected[i] == actual,  
                    " i: "+i.ToString() + " : (" + userInput[i][0] +","+ userInput[i][1]+")");
            }

        }
    }
}
