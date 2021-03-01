using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        private static void Main()
        {
            double imc, peso, altura;

            Console.WriteLine("Altura em metros");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Peso");
            peso = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);


            Console.WriteLine("Seu imc é: " + imc);
        }
    }
}
