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

        [Fact]
        public void Should_return_Fizz_when_given_3times_number()
        {
            //given 
            int number = 3;
            var fizzBuzz = new FizzBuzz();
            // when
            string shout = FizzBuzz.CountOff(number);
            // then
            Assert.Equal("Fizz", shout);
        }

        [Fact]
        public void Should_return_Buzz_when_given_5times_number()
        {
            int number = 5;
            var fizzBuzz = new FizzBuzz();
            var shout = FizzBuzz.CountOff(number);
            Assert.Equal("Buzz",shout);
        }
    }
}