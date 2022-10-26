using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        private readonly int three = 3;
        private readonly int five = 5;
        public string CountOff(int number)
        {
            if (number % five == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}
