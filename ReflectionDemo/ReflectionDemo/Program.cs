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
            //var calculator = (Calculator)Activator.CreateInstance(type, 1, 2);
            //calculator.Sum();
            //calculator.Sum(3, 4);

            var instance = Activator.CreateInstance(type, 3, 4);
            var methodInfo = instance.GetType().GetMethod("Sum");
            var result = methodInfo.Invoke(instance, null);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
