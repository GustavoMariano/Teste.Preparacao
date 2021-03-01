using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius.Fahrenheit
{
    class Program
    {
        private static void Main()
        {
            double celsius, fahrenheit;

            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine(celsius + "º celsius é o mesmo que: " + fahrenheit + " Fahrenheit");
        }
    }
}
