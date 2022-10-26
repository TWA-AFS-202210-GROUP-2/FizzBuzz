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
            Assert.Equal("Buzz", shout);
        }

        [Fact]
        public void Should_return_Buzz_when_given_7times_number()
        {
            int number = 7;
            var fizzBuzz = new FizzBuzz();
            var shout = FizzBuzz.CountOff(number);
            Assert.Equal("Whizz", shout);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_given_3and5times_number()
        {
            int number = 15;
            var fizzBuzz = new FizzBuzz();
            var shout = FizzBuzz.CountOff(number);
            Assert.Equal("FizzBuzz", shout);
        }

        [Fact]
        public void Should_return_FizzWhizz_when_given_3and7times_number()
        {
            int number = 21;
            var fizzBuzz = new FizzBuzz();
            var shout = FizzBuzz.CountOff(number);
            Assert.Equal("FizzWhizz", shout);
        }

        [Fact]
        public void Should_return_BuzzWhizz_when_given_5and7times_number()
        {
            int number = 35;
            var fizzBuzz = new FizzBuzz();
            var shout = FizzBuzz.CountOff(number);
            Assert.Equal("BuzzWhizz", shout);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_when_given_3and5and7times_number()
        {
            int number = 105;
            var fizzBuzz = new FizzBuzz();
            var shout = FizzBuzz.CountOff(number);
            Assert.Equal("FizzBuzzWhizz", shout);
        }
    }
}