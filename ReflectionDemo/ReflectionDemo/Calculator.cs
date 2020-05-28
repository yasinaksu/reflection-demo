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

        public void Sum()
        {
            Console.WriteLine("{0} + {1} = {2}", _number1, _number2, (_number1 + _number2));
        }

        public void Sum(int number1, int number2)
        {
            Console.WriteLine("{0} + {1} = {2}", number1, number2, (number1 + number2));
        }
        public void Multiply()
        {
            Console.WriteLine("{0} * {1} = {2}", _number1, _number2, (_number1 * _number2));
        }
        public void Multiply(int number1, int number2)
        {
            Console.WriteLine("{0} * {1} = {2}", number1, number2, (number1 * number2));
        }
    }
}
