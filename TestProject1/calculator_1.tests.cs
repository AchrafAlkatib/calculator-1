using Xunit;

namespace calculator_1.tests
{
    public class CalcTest
    {
                       
            Calc calc = new Calc();
            

            [Fact]
            public void Addtest()
            {
                Assert.Equal(20, calc.Add(10, 10));
                Assert.Equal(-10, calc.Add(-5, -5));
                Assert.Equal(1.5,    calc.Add(0.9f, 0.6f));
            }

            [Fact]
            public void Subtest()
            {
                Assert.Equal(0, calc.Subtract(10, 10));
                Assert.Equal(-2, calc.Subtract(-5, -3));
                Assert.Equal(2.5, calc.Subtract(5, 2.5f));
            }
            [Fact]
            public void Multest()
            {
                Assert.Equal(100, calc.Multiply(10, 10));
                Assert.Equal(-30, calc.Multiply(-5, 6));
                Assert.Equal(0.5, calc.Multiply(0.25f, 2));
            }
            [Fact]
            public void Divtest()
            {
                Assert.Equal(1, calc.Divide(10, 10));
                Assert.Equal(-1, calc.Divide(-3, 3));
                Assert.Equal(0.25, calc.Divide(0.5f, 2));

            }
        }
    }
