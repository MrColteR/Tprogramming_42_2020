using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestFunction1()
        {
            var actualResult = Program.Calc(1, 2, 2);
            Assert.Equal(double.NaN, actualResult);
        }

        [Fact]
        public void TestFunction2()
        {
            var actualResult = Program.Calc(1, 1, 0);
            Assert.Equal(double.NaN, actualResult);
        }

        [Fact]
        public void TestFunction3()
        {
            var actualResult = Program.Calc(1, 0, 0);
            Assert.Equal(double.NaN, actualResult);
        }

        [Fact]
        public void TestFunction4()
        {
            var actualResult = Program.TaskA(2, 1.1, 0.08, 1.08, 0.2);
            Assert.Equal(6, actualResult.Length);
        }

        [Fact]
        public void TestFunction5()
        {
            var actualResult = Program.TaskA(2, 1.1, 1, 6, 1);
            Assert.Equal(6, actualResult.Length);
            double[] expX = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i <= 5; i++)
            {
                var (x, y) = actualResult[i];
                Assert.Equal(expX[i], x, 1);
            }
        }

        [Fact]
        public void TestFunction6()
        {
            var actualResult = Program.TaskA(2, 1.1, 1, 2, 1);
            Assert.Equal(2, actualResult.Length);
            double[] expX = { 1, 2 };
            for (int i = 0; i < 1; i++)
            {
                var (x, y) = actualResult[i];
                Assert.Equal(expX[i], x, 1);
            }
        }

        [Fact]
        public void TestFunction7()
        {
            double[] xTest = { 1, 2, 3 };
            var actualResult = Program.TaskB(2, 1.1, xTest);
            Assert.Equal(3, actualResult.Length);
        }

        [Fact]
        public void TestFunction8()
        {
            double[] xTest = { };
            var actualResult = Program.TaskB(2, 1, xTest);
            var a = actualResult.Length;
            Assert.Equal(0, a);
        }
    }
}
