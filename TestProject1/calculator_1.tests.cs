using Xunit;
using System.Collections.Generic;

namespace calculator_1.tests
{
    public class CalcTest
    {

        Calc calc = new Calc();


        [Theory]
        [InlineData(8, 8, 16)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2.50, -2.25, -4.75)]
        public void CanAddTheory(float num1, float num2, float expected)
        {
            var result = calc.Add(num1, num2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new float[] { 4, 4, 4, 4 }, 16)]
        public void CanAddArray(float[] array, float expected)
        {
            List<float> numbers = new List<float>();

            foreach (float f in array)
            {
                numbers.Add(f);
            }
            Assert.Equal(expected, calc.Add(numbers));


        }




        [Theory]
        [InlineData(16, 10, 6)]
        [InlineData(-10, -6, -4)]
        [InlineData(-10.5, -5.25, -5.25)]
        public void CanSubtractTheory(float num1, float num2, float expected)
        {
            var result = calc.Subtract(num1, num2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new float[] { -2.2f, 5.5f, -8.2f, 61.1f, }, -60.6)]
        public void CanSubtractArray(float[] array, float expected)
        {
            List<float> numbers = new List<float>();

            foreach (float f in array)
            {
                numbers.Add((float)f);
            }
            Assert.Equal(expected, calc.Subtract(numbers));


        }
        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(-7, -8, 56)]
        [InlineData(-6.6, -5.4, 35.64)]
        public void CanMultiplyTheory(float num1, float num2, float expected)
        {
            var result = calc.Multiply(num1, num2);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(94, 2, 47)]
        [InlineData(-5, -2, 2.5)]
        [InlineData(-6.6, -2.2, 3)]
        public void CanDivideTheory(float num1, float num2, float expected)
        {
            var result = calc.Divide(num1, num2);
            Assert.Equal(expected, result);
        }

      }
    }
