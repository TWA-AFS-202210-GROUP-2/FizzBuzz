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
            Student class1 = new Student();

            //then
            Assert.NotNull(class1);
        }

        [Fact]
        public void Should_return_number()
        {
            //given
            var number = 1;
            //when
            var result = new Student().Count(number);
            //then
            Assert.Equal("1", result);
        }

        [Fact]
        public void Should_return_fizz()
        {
            //given
            var number = 3;
            //when
            var result = new Student().Count(number);
            //then
            Assert.Equal("fizz", result);
        }

        [Fact]
        public void Should_return_bizz()
        {
            //given
            var number = 5;
            //when
            var result = new Student().Count(number);
            //then
            Assert.Equal("bizz", result);
        }

        [Fact]
        public void Should_return_wizz()
        {
            //given
            var number = 7;
            //when
            var result = new Student().Count(number);
            //then
            Assert.Equal("wizz", result);
        }

        [Fact]
        public void Should_return_fizzwizz()
        {
            //given
            var number = 21;
            //when
            var result = new Student().Count(number);
            //then
            Assert.Equal("fizwizz", result);
        }

        [Fact]
        public void Should_return_fizzbizz()
        {
            //given
            var number = 15;
            //when
            var result = new Student().Count(number);
            //then
            Assert.Equal("fizwizz", result);
        }

        [Fact]
        public void Should_return_bizzwizz()
        {
            //given
            var number = 70;
            //when
            var result = new Student().Count(number);
            //then
            Assert.Equal("bizwizz", result);
        }

        [Fact]
        public void Should_return_fizzbizzwizz()
        {
            //given
            var number = 105;
            //when
            var result = new Student().Count(number);
            //then
            Assert.Equal("fizzbizwizz", result);
        }

        [Fact]
        public void Should_return_fizz_also()
        {
            //given
            var number = 13;
            //when
            var result = new Student().Count(number);
            //then
            Assert.Equal("fizz", result);
        }

        [Fact]
        public void Should_return_fizz_now()
        {
            //given
            var number = 35;
            //when
            var result = new Student().Count(number);
            //then
            Assert.Equal("fizz", result);
        }
    }
}