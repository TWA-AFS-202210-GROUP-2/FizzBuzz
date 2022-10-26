using FizzBuzz;
using Microsoft.VisualBasic;
using System;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void IsInputNumberValid()
        {
            var testNumber = -10;
            FizzBuzzWhizz fizzBuzz = new FizzBuzzWhizz();
            Action action = () => fizzBuzz.CountingNumber(testNumber);
            Assert.Throws<InputNumberNotValidException>(action);
        }

        [Fact]
        public void ShouldSayFizzWhen3Multiples()
        {
            var testNumber = 3;
            FizzBuzzWhizz fizzBuzz = new FizzBuzzWhizz();
            var countingResult = fizzBuzz.CountingNumber(testNumber);

            Assert.Equal("Fizz", countingResult);
        }

        [Fact]
        public void ShouldSayBuzzWhen5Multiples()
        {
            var testNumber = 5;
            FizzBuzzWhizz fizzBuzz = new FizzBuzzWhizz();
            var countingResult = fizzBuzz.CountingNumber(testNumber);

            Assert.Equal("Buzz", countingResult);
        }

        [Fact]
        public void ShouldSayWhizzWhen7Multiples()
        {
            var testNumber = 7;
            FizzBuzzWhizz fizzBuzz = new FizzBuzzWhizz();
            var countingResult = fizzBuzz.CountingNumber(testNumber);

            Assert.Equal("Whizz", countingResult);
        }

        [Fact]
        public void ShouldSayNumberWhenNoSpecial()
        {
            var testNumber = 19;
            FizzBuzzWhizz fizzBuzz = new FizzBuzzWhizz();
            var countingResult = fizzBuzz.CountingNumber(testNumber);

            Assert.Equal("19", countingResult);
        }

        [Fact]
        public void ShouldSayFizzBuzzWhen3and5Multiples()
        {
            var testNumber = 15;
            FizzBuzzWhizz fizzBuzz = new FizzBuzzWhizz();
            var countingResult = fizzBuzz.CountingNumber(testNumber);

            Assert.Equal("FizzBuzz", countingResult);
        }

        [Fact]
        public void ShouldSayFizzWhizzWhen3and7Multiples()
        {
            var testNumber = 21;
            FizzBuzzWhizz fizzBuzz = new FizzBuzzWhizz();
            var countingResult = fizzBuzz.CountingNumber(testNumber);

            Assert.Equal("FizzWhizz", countingResult);
        }

        [Fact]
        public void ShouldSayBuzzWhizzWhen5and7Multiples()
        {
            var testNumber = 70;
            FizzBuzzWhizz fizzBuzz = new FizzBuzzWhizz();
            var countingResult = fizzBuzz.CountingNumber(testNumber);

            Assert.Equal("BuzzWhizz", countingResult);
        }

        [Fact]
        public void ShouldSayFizzBuzzWhizzWhen3_5_7Multiples()
        {
            var testNumber = 105;
            FizzBuzzWhizz fizzBuzz = new FizzBuzzWhizz();
            var countingResult = fizzBuzz.CountingNumber(testNumber);

            Assert.Equal("FizzBuzzWhizz", countingResult);
        }

        [Fact]
        public void ShouldSayFizzWhen3Exists()
        {
            var testNumber = 13;
            FizzBuzzWhizz fizzBuzz = new FizzBuzzWhizz();
            var countingResult = fizzBuzz.CountingNumber(testNumber);

            Assert.Equal("Fizz", countingResult);
        }
    }
}