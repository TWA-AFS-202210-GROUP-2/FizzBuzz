using FizzBuzz;
using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void Test1()
        {
            Class1 class1 = new Class1();

            //then
            Assert.NotNull(class1);
        }

        [Fact]
        public void Should_return_norml_number_when_count_off_given_normal_number()
        {
            // given
            var fizzbuzzgame = new FizzBuzzGame();

            // when
            string result = fizzbuzzgame.CountOff(1);

            // then
            Assert.Equal("1", result);
        }

        public void Should_return_true_when_count_off_given_contains_3()
        {
            // given
            var fizzbuzzgame = new FizzBuzzGame();

            // when
            bool result = fizzbuzzgame.Contain3(31);

            // then
            Assert.True(result);
        }
    }
}