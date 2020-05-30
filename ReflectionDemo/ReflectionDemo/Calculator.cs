using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Calculator
    {
        private int _number1;
        private int _number2;
        public Calculator(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public int Sum()
        {
            return _number1 + _number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
