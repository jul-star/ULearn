using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Rectangles;

namespace MyXUnitTests
{
    public class RectanglesUnitTest
    {
        [Fact]
        public static void AreIntersected_0()
        {
            Rectangle r1 = new Rectangle(0,0,0,0);
            Rectangle r2 = new Rectangle(0,0,0,0);
            bool actual = RectanglesTask.AreIntersected(r1, r2);
            bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void AreIntersected_1()
        {
            Rectangle r1 = new Rectangle(0,0,1,1);
            Rectangle r2 = new Rectangle(0,0,2,2);
            bool actual = RectanglesTask.AreIntersected(r1, r2);
            bool expected = true;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public static void AreIntersected_2()
        {
            Rectangle r1 = new Rectangle(0,0,2,2);
            Rectangle r2 = new Rectangle(0,0,1,1);
            bool actual = RectanglesTask.AreIntersected(r1, r2);
            bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void AreIntersected_r2inr1()
        {
            Rectangle r1 = new Rectangle(-40, -40, 110, 110);
            Rectangle r2 = new Rectangle(30, -30, 30, 30);
            bool actual = RectanglesTask.AreIntersected(r1, r2);
            bool expected = true;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public static void AreIntersected_crest()
        {
            Rectangle r1 = new Rectangle(-90, -20, 180, 40);
            Rectangle r2 = new Rectangle(-20, -90, 40, 180);
            bool actual = RectanglesTask.AreIntersected(r1, r2);
            bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void DeltaX_r1inr2()
        {
            Rectangle r1 = new Rectangle(0,0,1,1);
            Rectangle r2 = new Rectangle(0,0,2,2);
            int actual = RectanglesTask.DeltaX(r1, r2);
            int expected = 1;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void DeltaX_r1inr2_inside()
        {
            Rectangle r1 = new Rectangle(1,1,1,1);
            Rectangle r2 = new Rectangle(0,0,2,2);
            int actual = RectanglesTask.DeltaX(r1, r2);
            int expected = 1;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void DeltaX_r2inr1()
        {
            Rectangle r1 = new Rectangle(0,0,2,2);
            Rectangle r2 = new Rectangle(0,0,1,1);
            int actual = RectanglesTask.DeltaX(r1, r2);
            int expected = 1;
            Assert.Equal(expected, actual);
        }

        public static void DeltaX__r2inr1_1()
        {
            Rectangle r1 = new Rectangle(-40, -40, 110, 110);
            Rectangle r2 = new Rectangle(30, -30, 30, 30);
            int actual = RectanglesTask.DeltaX(r1, r2);
            int expected = 1;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public static void DeltaX_crest()
        {
            Rectangle r1 = new Rectangle(-90, -20, 180, 40);
            Rectangle r2 = new Rectangle(-20, -90, 40, 180);
            int actual = RectanglesTask.DeltaX(r1, r2);
            int expected = 40;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void DeltaX_r1inr2_2()
        {
            Rectangle r1 = new Rectangle(-30, -30, 30, 30);
            Rectangle r2 = new Rectangle(-40, -40, 110, 110);
            int actual = RectanglesTask.DeltaX(r1, r2);
            int expected = 30;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void DeltaX_R1OverlapR2_3()
        {
            Rectangle r1 = new Rectangle(0, 0, 30, 30);
            Rectangle r2 = new Rectangle(-20, -20, 30, 30);
            int actual = RectanglesTask.DeltaX(r1, r2);
            int expected = 10;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public static void DeltaY_R1OverlapR2_1()
        {
            Rectangle r1 = new Rectangle(0, 0, 30, 30);
            Rectangle r2 = new Rectangle(-20, -20, 30, 30);
            int actual = RectanglesTask.DeltaY(r1, r2);
            int expected = 10;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void IntersectionSquare_0()
        {
            Rectangle r1 = new Rectangle(0,0,1,1);
            Rectangle r2 = new Rectangle(0,0,2,2);
            int actual = RectanglesTask.IntersectionSquare(r1, r2);
            int expected = 1;
            Assert.Equal(expected, actual);

        }
    }
}
