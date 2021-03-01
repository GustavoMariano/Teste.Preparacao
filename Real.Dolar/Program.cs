using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real.Dolar
{
    class Program
    {
        private static void Main()
        {
            double real, dolar;

            Console.WriteLine("Digite a quantia em reais");
            real = Convert.ToDouble(Console.ReadLine());

            dolar = real * 5.58;

            Console.WriteLine("R$ " + real + " é o mesmo que $ " + dolar);
        }
    }
}
