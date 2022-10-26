using System;
using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    using FizzBuzz;
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_return_normal_number_when_given_normal_number()
        {
            //given
            int number = 1;
            var fizzBuzz = new FizzBuzz();
           //when
           string shout = FizzBuzz.CountOff(number);

            //then
            Assert.Equal(number.ToString(), shout);
        }
    }
}