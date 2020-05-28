using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(Calculator);
            var calculator = (Calculator)Activator.CreateInstance(type, 1, 2);

            calculator.Sum();
            calculator.Sum(3, 4);

            Console.ReadLine();
        }
    }
}
