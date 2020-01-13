using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Branching;

namespace MyXUnitTests
{
    public class RobotUnitTest
    {
        [Fact]
        public static void Test()
        {
            Assert.True(Robot.ShouldFire0(false, "me", 50) ==
                        Robot.ShouldFire(false, "me", 50));
        }
    }
}
