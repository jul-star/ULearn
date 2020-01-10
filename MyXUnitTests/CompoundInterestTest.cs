using System;
using System.Collections.Generic;
using Xunit;
using CompoundInterest;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace MyXUnitTests
{
    public class UnitTestCompoundInterest
    {
        //[Fact]
        //public void TestConvertStringToValues_0()
        //{
        //    Tuple<double, double, int> actual = Balance.ConvertStringToValues("100.00 12 1");
        //    Tuple<double, double, int> expected = new Tuple<double, double, int>(100.0, 12.0, 1);
        //    Assert.Equal(expected, actual);
        //}

        [Fact]
        public void TestConvertStringToValues_1()
        {
            Tuple<double, double, int> actual = Balance.ConvertStringToValues("100,00 12 1");
            Tuple<double, double, int> expected = new Tuple<double, double, int>(100.0, 12.0, 1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculate_0()
        {
            double actual = Balance.Calculate("100,00 12 0");
            double expected = 100.0;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculate_1()
        {
            double actual = Balance.Calculate("100,00 12 1");
            double expected = 101.0;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalculate_3()
        {
            double actual = Balance.Calculate("1000,1 1,2 1");
            double expected = 1001.1001;
            Assert.Equal(expected, actual, 4);
            
        }

        [Fact]
        public void TestCalculate_2()
        {
            double actual = Balance.Calculate("100,00 12 2");
            double expected = 102.01;
            Assert.Equal(expected, actual);
        }
    }



}
