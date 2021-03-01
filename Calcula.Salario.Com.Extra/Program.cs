using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula.Salario.Com.Extra
{
    class Program
    {
        static void Main()
        {
            string nome;
            double salarioFinal, salarioExtra, valorHora = 10;
            int totalHoras, horasExtras;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade total de horas inteiras feita no mes.");
            totalHoras = Convert.ToInt32(Console.ReadLine());

            if(totalHoras > 160)
            {
                horasExtras = totalHoras - 160;
                salarioExtra = (valorHora * 1.5) * horasExtras; //A hora extra é o equivalente a hora normal mais um acréscimo de 50%

                salarioFinal = salarioExtra + valorHora * 160;
            }
            else
            {
                salarioFinal = totalHoras* valorHora;
            }

            Console.WriteLine(nome + " seu salário total é: R$ " + salarioFinal);
        }
    }
}
