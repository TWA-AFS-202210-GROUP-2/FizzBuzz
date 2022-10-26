using System;

namespace FizzBuzzTask
{
    public class FizzBuzz
    {
        public string CountOff(int number)
        {
            if (number.ToString().Contains("3")) { return "Fizz"; }
            if (number % 3 == 0 && number % 5 == 0 && number % 7 == 0) { return "FizzBuzzWhizz"; }
            if (number % 3 == 0 && number % 5 == 0) { return "FizzBuzz"; }
            if (number % 3 == 0 && number % 7 == 0) { return "FizzWhizz"; }
            if (number % 5 == 0 && number % 7 == 0) { return "BuzzWhizz"; }
            if (number % 3 == 0) { return "Fizz"; }
            if (number % 5 == 0) { return "Buzz"; }
            if (number % 7 == 0) { return "Whizz"; }
            return number.ToString();
        }
    }
}
