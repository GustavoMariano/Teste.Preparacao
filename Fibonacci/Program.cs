using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {            
            int num1 = 1, num2 = 0, resultado = 0; //x y z

            int quantidade; //qtd para for
            quantidade = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                resultado = num1 + num2;
                Console.WriteLine(resultado);
                num1 = num2;
                num2 = resultado;
            }
        }
    }
}
