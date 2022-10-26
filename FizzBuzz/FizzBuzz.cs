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
