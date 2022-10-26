using System;

namespace FizzBuzz
{
    public class Student
    {
        public string Count(int number)
        {
            if (number % 3 == 0)
            {
                return "fizz";
            }

            if (number % 5 == 0)
            {
                return "bizz";
            }

            if (number % 5 == 0)
            {
                return "wizz";
            }

            return number.ToString();
        }
    }
}
