using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        private readonly int three = 3;
        private readonly int five = 5;
        private readonly int seven = 7;
        public string CountOff(int number)
        {
            bool isContains3 = Contain3(number);
            bool isDivisiblByThree = DivisiblByThree(number);
            bool isDivisiblByFive = DivisiblByFive(number);
            bool isDivisiblBySeven = DivisiblBySeven(number);
            if (isContains3)
            {
                return "Fizz";
            }

            if (isDivisiblByThree & !isDivisiblByFive & !isDivisiblBySeven)
            {
                return "Fizz";
            }

            if (!isDivisiblByThree & isDivisiblByFive & !isDivisiblBySeven)
            {
                return "Buzz";
            }

            if (!isDivisiblByThree & !isDivisiblByFive & isDivisiblBySeven)
            {
                return "Whizz";
            }

            if (isDivisiblByThree & isDivisiblByFive & !isDivisiblBySeven)
            {
                return "FizzBuzz";
            }

            if (!isDivisiblByThree & isDivisiblByFive & isDivisiblBySeven)
            {
                return "BuzzWhizz";
            }

            if (isDivisiblByThree & !isDivisiblByFive & isDivisiblBySeven)
            {
                return "FizzWhizz";
            }

            if (isDivisiblByThree & isDivisiblByFive & isDivisiblBySeven)
            {
                return "FizzBuzzWhizz";
            }

            return number.ToString();
        }

        public bool DivisiblByThree(int num)
        {
            return num % three == 0;
        }

        public bool DivisiblByFive(int num)
        {
            return num % five == 0;
        }

        public bool DivisiblBySeven(int num)
        {
            return num % seven == 0;
        }

        public bool Contain3(int num)
        {
            return num.ToString().Contains("3");
        }
    }
}
