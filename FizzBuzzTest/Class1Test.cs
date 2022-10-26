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
    }
}