using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        private readonly int three = 3;
        private readonly int five = 5;
        private readonly int seven = 7;
        public string CountOff(int number)
        {
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
