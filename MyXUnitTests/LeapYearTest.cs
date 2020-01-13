using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Branching;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace MyXUnitTests
{
    public class LeapYearUnitTest
    {
        [Fact]
        public void Test01()
        {
            List<int> input = new List<int>{
                2014,
                1999,
                8992,
                1,
                14,
                400,
                600,
                3200};
            List<bool> expected = new List<bool>{
                false,
                false,
                true,
                false,
                false,
                true,
                false,
                true};
            for (int i = 0; i < expected.Count; ++i)
            {
                bool actual = LeapYear.IsLeapYear(input[i]);
                Assert.Equal(expected[i], actual);
            }
           
        }

    }
}
