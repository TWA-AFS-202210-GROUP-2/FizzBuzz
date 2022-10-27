using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace FizzBuzz
{
    public class FizzBuzzWhizz
    {
        public FizzBuzzWhizz()
        {
        }

        /*private Enum MultiplesType()
        {
            ThreeAndFive,
            ThreeAndSeven,
            FiveAndSeven,
            ThreeAndFiveAndSeven
        };*/

        public string CountingNumber(int num)
        {
            if (!this.InputValidtor(num))
            {
                throw new InputNumberNotValidException("input number is not valid!");
            }

            if (this.ContentThree(num))
            {
                return "Fizz";
            }
            else if (this.MultiplesOfMany(num).Item1)
            {
                return this.MultiplesOfMany(num).Item2;
            }
            else if (this.MultipleFive(num).Item1)
            {
                return this.MultipleFive(num).Item2;
            }
            else if (this.MultipleSeven(num).Item1)
            {
                return this.MultipleSeven(num).Item2;
            }
            else if (this.MultipleThree(num).Item1)
            {
                return this.MultipleThree(num).Item2;
            }
            else
            {
                return num.ToString();
            }
        }

        private bool InputValidtor(int num)
        {
            if (num <= 0)
            {
                return false;
            }

            return true;
        }

        private bool ContentThree(int num)
        {
            var numToStr = num.ToString();
            if (numToStr.Contains("3"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private (bool, string) MultipleFive(int num)
        {
            if (num % 5 == 0)
            {
                return (true, "Buzz");
            }
            else
            {
                return (false, " ");
            }
        }

        private (bool, string) MultipleSeven(int num)
        {
            if (num % 7 == 0)
            {
                return (true, "Whizz");
            }
            else
            {
                return (false, " ");
            }
        }

        private (bool, string) MultipleThree(int num)
        {
            if (num % 3 == 0)
            {
                return (true, "Fizz");
            }
            else
            {
                return (false, " ");
            }
        }

        private (bool, string) MultiplesOfMany(int num)
        {
            if (num % 3 == 0 && num % 5 == 0 && num % 7 == 0)
            {
                return (true, "FizzBuzzWhizz");
            }
            else if (num % 3 == 0 && num % 5 == 0)
            {
                return (true, "FizzBuzz");
            }
            else if (num % 3 == 0 && num % 7 == 0)
            {
                return (true, "FizzWhizz");
            }
            else if (num % 5 == 0 && num % 7 == 0)
            {
                return (true, "BuzzWhizz");
            }
            else
            {
                return (false, " ");
            }
        }
    }
}
