using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Program
    {
        static void Main()
        {
            double media, soma = 0;

            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Numero: ");
                soma += Convert.ToDouble(Console.ReadLine());
            }
            media = soma / 5;
            Console.WriteLine("Media: " + media);

        }
    }
}
