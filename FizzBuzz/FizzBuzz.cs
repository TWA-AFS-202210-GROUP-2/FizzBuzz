using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string CountOff(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}
