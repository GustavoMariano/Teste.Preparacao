using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo.Par.Impar
{
    class Program
    {
        private static void Main()
        {
            int num;
            Console.WriteLine("Digite um numero");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("É Par");
            }
            else
            {
                Console.WriteLine("É Impar");
            }
        }
    }
}
