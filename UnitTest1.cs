using System;
using Xunit;

namespace TDDNetCore_Example
{
    public class UnitTest1
    {
        /*
        [Fact]
        public void ValidateCalculatroMethodAdd()
        {
            var result = Add(5, 6);

            Assert.Equal(11, result);
        }

        [Fact]
        public void ValidateCalculatroMethodAdd2Digit()
        {
            var result = Add(50, 69);

            Assert.Equal(119, result);
        }

        [Fact]
        public void ValidateCalculatroMethodAdd3Digit()
        {
            var result = Add(500, 691);

            Assert.Equal(1191, result);
        }
        */

        [Theory]
        [InlineData(5, 6, 11)]
        [InlineData(50, 69, 119)]
        [InlineData(500, 691, 1191)]
        public void ValidateCalculatroMethodAdd(int frist, int second, int expected) {
            var result = Add(frist, second);

            Assert.Equal(expected, result);
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
