using System;
using Xunit;

namespace TDDNetCore_Example
{
    public class UnitTest1
    {
        //Fact can not have parametor
        [Fact(DisplayName="check add on 3 digit number")]
        public void ValidateCalculatroMethodAdd3Digit()
        {
            var result = Add(500, 691);

            Assert.Equal(1191, result);
        }

        //Theory add parameter
        [Theory(DisplayName="check add")]
        [InlineData(5, 6, 1)]
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
