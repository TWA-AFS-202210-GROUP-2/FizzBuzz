using System;

namespace FizzBuzz
{
    public class Student
    {
        public string Count(int number)
        {
            if (number.ToString().Contains("3"))
            {
                return "fizz";
            }

            if (number % 3 == 0 && number % 7 == 0 && number % 5 == 0)
            {
                return "fizzbizzwizz";
            }

            if (number % 3 == 0 && number % 7 == 0)
            {
                return "fizzwizz";
            }

            if (number % 3 == 0 && number % 5 == 0)
            {
                return "fizzbizz";
            }

            if (number % 7 == 0 && number % 5 == 0)
            {
                return "bizzwizz";
            }

            if (number % 3 == 0)
            {
                return "fizz";
            }

            if (number % 5 == 0)
            {
                return "bizz";
            }

            if (number % 7 == 0)
            {
                return "wizz";
            }

            return number.ToString();
        }
    }
}
