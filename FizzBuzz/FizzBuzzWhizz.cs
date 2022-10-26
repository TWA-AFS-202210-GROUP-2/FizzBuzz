using System;

namespace FizzBuzz
{
    public class FizzBuzzWhizz
    {
        public FizzBuzzWhizz()
        {
        }

        public string CountingNumber(int num)
        {
            if (num % 7 == 0)
            {
                return "Whizz";
            }
            else
            {
                return CallBuzz(num - 1);
            }
        }

        private int CallNumber(int num)
        {
            return num;
        }

        private string CallFizz(int num)
        {
            return "Fizz";
        }

        private string CallBuzz(int num)
        {
            return "Buzz";
        }

        private string CallWhizz(int num)
        {
            return "Whizz";
        }

        private string CallFizzBuzz(int num)
        {
            return "WFizzBuzz";
        }
    }
}
