using System;
using System.Collections.Generic;
using Xunit;
using _02_Errors;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace MyXUnitTests
{
    public class MinXUnitTest
    {
        [Fact]
        public void Test1()
        {

            var TupleList = new List<(int, int, int)>
            {
                (1, 2, 3),
                (0, 3, 2),
                (1, -2, -3),
                (5, 2, 1),
                (4, 3, 2),
                (0, 4, 5)
            };
            var Expected = new List<String>
            {
                "-1",
                "Impossible",
                "1",
                "-0,2",
                "-0,375",
                "Impossible",
            };
            for (int i = 0;
                i < TupleList.Count;
                ++i)
            {
                var Actual = MinX.GetMinX(TupleList[i].Item1, TupleList[i].Item2, TupleList[i].Item3);
                Assert.True(Expected[i] == Actual, "Wrong : " + i.ToString() + " Actual: " + Actual.ToString());
            }
        }

        [Fact]
        public void Test2()
        {

            var TupleList = new List<(int, int, int)>
            {
                (0,0,2),
                (0,0,0)
            };
            var Expected = "Impossible";
            for (int i = 0;
                i < TupleList.Count;
                ++i)
            {
                Assert.False(Expected == MinX.GetMinX(TupleList[i].Item1, TupleList[i].Item2, TupleList[i].Item3),i.ToString() );
            }
        }


    }
}
