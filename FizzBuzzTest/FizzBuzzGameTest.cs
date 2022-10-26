using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_normal_number_When_CountOff_Given_normal_number()
        {
            //given
            var fizzBuzz = new FizzBuzzGame();
            int number = 1;
            //when
            var result = fizzBuzz.CountOff(number);
            //then
            Assert.Equal("1", result);
        }

        [Fact]
        public void Should_return_Fizz_When_CountOff_Given_multiple_of_3()
        {
            //given
            var fizzBuzz = new FizzBuzzGame();
            int number = 6;
            //when
            var result = fizzBuzz.CountOff(number);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Buzz_When_CountOff_Given_multiple_of_5()
        {
            //given
            var fizzBuzz = new FizzBuzzGame();
            int number = 5;
            //when
            var result = fizzBuzz.CountOff(number);
            //then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_Whizz_When_CountOff_Given_multiple_of_7()
        {
            //given
            var fizzBuzz = new FizzBuzzGame();
            int number = 7;
            //when
            var result = fizzBuzz.CountOff(number);
            //then
            Assert.Equal("Whizz", result);
        }
    }
}