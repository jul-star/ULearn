using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Cycles;

namespace MyXUnitTests
{
   public class RemoveWhiteSpacesTest
    {
        [Fact]
        public static void Test()
        {
            string actual = RemoveWhiteSpaces.RemoveStartSpaces("               ");
            string expected = string.Empty;
            Assert.Equal(expected, actual);
        }
    }
}
