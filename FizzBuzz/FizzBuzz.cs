using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        private readonly int three = 3;
        private readonly string string_three = "3";
        private readonly int five = 5;
        private readonly int seven = 7;
        public string CountOff(int number)
        {
            if (number.ToString().Contains(string_three))
            {
                return "Fizz";
            }

            if (number % three == 0 && number % five == 0 && number % seven == 0)
            {
                return "FizzBuzzWhizz";
            }

            if (number % three == 0 && number % five == 0)
            {
                return "FizzBuzz";
            }

            if (number % three == 0 && number % seven == 0)
            {
                return "FizzWhizz";
            }

            if (number % five == 0 && number % seven == 0)
            {
                return "BuzzWhizz";
            }

            if (number % three == 0)
            {
                return "Fizz";
            }

            if (number % five == 0)
            {
                return "Buzz";
            }

            if (number % seven == 0)
            {
                return "Whizz";
            }

            return number.ToString();
        }
    }
}
