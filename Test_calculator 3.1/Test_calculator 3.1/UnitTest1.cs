using System;
using Xunit;
using Calculator;

namespace Test_Codewars.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange section  
            int a = 10;
            int b = 5;
            int expected = 15;
            //Act section
            int actual = Measurments.Sum(a, b);
            //Assert section
            Assert.Equal(expected, actual);
            //Assert.Equal(10, Measurments.Sum(5, 5));
        }
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-17, 5, -12)]
        [InlineData(0, 0, 0)]
        public void Test_Sum(int a, int b, int expected)
        {
            //Act section
            int actual = Measurments.Sum(a, b);
            //Assert section
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(-25, -15, -10)]
        [InlineData(0, 0, 0)]
        public void Test_Sub(int a, int b, int expected)
        {
            //Act section
            int actual = Measurments.Sub(a, b);
            //Assert section
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(-5, 3, -15)]
        [InlineData(0, 0, 0)]
        public void Test_Mult(int a, int b, int expected)
        {
            //Act section
            int actual = Measurments.Mult(a, b);
            //Assert section
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(-15, 5, -3)]
        public void Test_Div(int a, int b, int expected)
        {
            //Act section
            double actual = Measurments.Div(a, b);
            //Assert section
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(25, 5)]
        [InlineData(0, 0)]
        public void Test6(int a, int expected)
        {
            //Act section
            double actual = Measurments.Square(a);
            //Assert section
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test7()
        {
            //Arrange section
            int a = 0;
            int expected = 0;
            //Act section
            double actual = Measurments.Square(a);
            //Assert section
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test8()
        {
            int a = 5;
            int b = 0;
            Action act = () => Measurments.Div(a, b);
            Assert.Throws<DivideByZeroException>(act);
        }
        [Fact]
        public void Test9()
        {
            int a = -1;
            Action act = () => Measurments.Square(a);
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }
    }
}
