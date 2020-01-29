using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using  Xunit;
using Collections;

namespace MyXUnitTests
{
    public class DecodingTest
    {
        [Fact]
        public static void ApplyCommandsTest()
        {
            string[] user_input = 
            {
                "push Привет! Это снова я! Пока!",
                "pop 5",
                "push Как твои успехи? Плохо?",
                "push qwertyuiop",
                "push 1234567890",
                "pop 26"
            };
            string vActual = Decoding.ApplyCommands(user_input);
            string vExpected = "Привет! Это снова я! Как твои успехи? ";
            Assert.Equal(vExpected, vActual);
        }
    }
}
