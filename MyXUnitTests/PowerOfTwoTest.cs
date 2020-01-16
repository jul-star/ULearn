using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Cycles;

namespace MyXUnitTests
{
    public class PowerOfTwoTest
    {
        [Fact]
        public static void Test()
        {
            int actual = PowerOfTwo.GetMinPowerOfTwoLargerThan(1);
            int expected = 1;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void TestSet()
        {
            int[] userInput = { 2, 15, -2, -100, 100 };
            int[] expected = { 4, 16, 1, 1, 128 };
            for (int i = 0; i < userInput.Length; i++)
            {
                int actual = PowerOfTwo.GetMinPowerOfTwoLargerThan(userInput[i]);
                Assert.Equal(expected[i], actual);
            }

        }
    }
}
