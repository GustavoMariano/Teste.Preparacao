using System;

namespace Principais.Operacoes.Aritmeticas
{
    class Program
    {
        static void Main()
        {
            int num1, num2;

            Console.WriteLine("Insira o primeiro numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adição: " + (num1 + num2));
            Console.WriteLine("Subtração: " + (num1 - num2));
            Console.WriteLine("Multiplicação: " + (num1 * num2));
            Console.WriteLine("Divisão: " + (num1 / num2));

            if(num1 % 2 == 0)
            {
                Console.WriteLine(num1 + " É par");
            }
            else
            {
                Console.WriteLine(num1 + " É impar");
            }

            if (num2 % 2 == 0)
            {
                Console.WriteLine(num2 + " É par");
            }
            else
            {
                Console.WriteLine(num2 + " É impar");
            }
        }
    }
}
