using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el número para calcular su factorial");
            int numFac = int.Parse(Console.ReadLine());
            int resultado = factorial(numFac);
        }

        private static int factorial(int numFac)
        {
            if(numFac > 0) 
            {
                int resultado = numFac * factorial(numFac - 1);
                Console.WriteLine("el resultado de la iteracion con valor: "+numFac
                    +" es: " + resultado);
                return resultado;
            }
            else 
            {
                Console.WriteLine("llegado a la ultima recursividad con numFac = " + numFac);
                return 1; 
            }
        }
    }
}
