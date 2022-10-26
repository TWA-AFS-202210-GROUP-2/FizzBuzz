using System;

namespace FizzBuzzTask
{
    public class FizzBuzz
    {
        public string CountOff(int number)
        {
            if (number % 3 == 0) { return "Fizz"; }
            if (number % 5 == 0) { return "Buzz"; }
            if (number % 7 == 0) { return "Whizz"; }
            return number.ToString();
        }
    }
}
