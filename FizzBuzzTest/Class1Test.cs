using FizzBuzzTask;
using Microsoft.VisualStudio.TestPlatform.Common.DataCollection;
using Moq;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void Should_normal_number_when_countoff_given_normal_number()
        {
            //given
            FizzBuzz class1 = new FizzBuzz();

            //when
            var result = class1.CountOff(2);
            //then
            Assert.Equal("2", result);
        }
    }
}