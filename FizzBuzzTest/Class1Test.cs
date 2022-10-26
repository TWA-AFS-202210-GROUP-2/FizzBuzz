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

        [Fact]
        public void Should_return_Fizz_when_count_off_given_only_DivisiblBySeven()
        {
            // given
            var fizzbuzzgame = new FizzBuzzGame();

            // when
            string result7 = fizzbuzzgame.CountOff(7);
            string result14 = fizzbuzzgame.CountOff(14);
            string result28 = fizzbuzzgame.CountOff(28);

            // then
            Assert.Equal("Whizz", result7);
            Assert.Equal("Whizz", result14);
            Assert.Equal("Whizz", result28);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_only_DivisiblByThree_and_Five()
        {
            // given
            var fizzbuzzgame = new FizzBuzzGame();

            // when
            string result15 = fizzbuzzgame.CountOff(15);
            string result30 = fizzbuzzgame.CountOff(30);
            string result60 = fizzbuzzgame.CountOff(60);

            // then
            Assert.Equal("FizzBuzz", result15);
            Assert.Equal("FizzBuzz", result60);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_only_DivisiblByThree_and_Seven()
        {
            // given
            var fizzbuzzgame = new FizzBuzzGame();

            // when
            string result21 = fizzbuzzgame.CountOff(21);
            string result42 = fizzbuzzgame.CountOff(42);
            string result63 = fizzbuzzgame.CountOff(63);

            // then
            Assert.Equal("FizzWhizz", result21);
            Assert.Equal("FizzWhizz", result42);
            Assert.Equal("Fizz", result63);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_only_DivisiblByFive_and_Seven()
        {
            // given
            var fizzbuzzgame = new FizzBuzzGame();

            // when
            string result70 = fizzbuzzgame.CountOff(70);
            string result35 = fizzbuzzgame.CountOff(35);

            // then
            Assert.Equal("BuzzWhizz", result70);
            Assert.Equal("Fizz", result35);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_only_DivisiblByThreeFive_and_Seven()
        {
            // given
            var fizzbuzzgame = new FizzBuzzGame();

            // when
            string result105 = fizzbuzzgame.CountOff(105);

            // then
            Assert.Equal("FizzBuzzWhizz", result105);
        }
    }
}