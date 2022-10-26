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
    }
}