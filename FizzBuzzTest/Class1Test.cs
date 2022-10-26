using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
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
    }
}