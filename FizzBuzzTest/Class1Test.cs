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

        [Fact]
        public void Should_return_true_when_count_off_given_contains_3()
        {
            // given
            var fizzbuzzgame = new FizzBuzzGame();

            // when
            bool result = fizzbuzzgame.Contain3(31);

            // then
            Assert.True(result);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_contains_3()
        {
            // given
            var fizzbuzzgame = new FizzBuzzGame();

            // when
            string result = fizzbuzzgame.CountOff(31);

            // then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_only_DivisiblByThree()
        {
            // given
            var fizzbuzzgame = new FizzBuzzGame();

            // when
            string result3 = fizzbuzzgame.CountOff(3);
            string result6 = fizzbuzzgame.CountOff(6);
            string result9 = fizzbuzzgame.CountOff(9);

            // then
            Assert.Equal("Fizz", result3);
            Assert.Equal("Fizz", result6);
            Assert.Equal("Fizz", result9);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_only_DivisiblByFive()
        {
            // given
            var fizzbuzzgame = new FizzBuzzGame();

            // when
            string result5 = fizzbuzzgame.CountOff(5);
            string result10 = fizzbuzzgame.CountOff(10);
            string result20 = fizzbuzzgame.CountOff(20);

            // then
            Assert.Equal("Buzz", result5);
            Assert.Equal("Buzz", result10);
            Assert.Equal("Buzz", result20);
        }
    }
}