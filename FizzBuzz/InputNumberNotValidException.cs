using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class InputNumberNotValidException : Exception
    {
        public InputNumberNotValidException(string message) : base(message)
        {
        }
    }
}
