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

        [Fact]
        public void Should_Fizz_when_countoff_given_only_multiply_of_3()
        {
            //given
            FizzBuzz class1 = new FizzBuzz();

            //when
            var result = class1.CountOff(3);
            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_Buzz_when_countoff_given_only_multiply_of_5()
        {
            //given
            FizzBuzz class1 = new FizzBuzz();

            //when
            var result = class1.CountOff(5);
            //then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_Whizz_when_countoff_given_only_multiply_of_7()
        {
            //given
            FizzBuzz class1 = new FizzBuzz();

            //when
            var result = class1.CountOff(7);
            //then
            Assert.Equal("Whizz", result);
        }

        [Fact]
        public void Should_FizzBuzz_when_countoff_given_multiply_of_3_and_5()
        {
            //given
            FizzBuzz class1 = new FizzBuzz();

            //when
            var result = class1.CountOff(15);
            //then
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Should_FizzWhizz_when_countoff_given_multiply_of_3_and_7()
        {
            //given
            FizzBuzz class1 = new FizzBuzz();

            //when
            var result = class1.CountOff(21);
            //then
            Assert.Equal("FizzWhizz", result);
        }

        [Fact]
        public void Should_BuzzWhizz_when_countoff_given_multiply_of_5_and_7()
        {
            //given
            FizzBuzz class1 = new FizzBuzz();

            //when
            var result = class1.CountOff(35);
            //then
            Assert.Equal("BuzzWhizz", result);
        }

        [Fact]
        public void Should_FizzBuzzWhizz_when_countoff_given_multiply_of_3_and_5_and_7()
        {
            //given
            FizzBuzz class1 = new FizzBuzz();

            //when
            var result = class1.CountOff(105);
            //then
            Assert.Equal("FizzBuzzWhizz", result);
        }
    }
}