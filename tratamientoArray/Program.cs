using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tratamientoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qué cantidad de números quieres operar");
            int num = int.Parse(Console.ReadLine());
            int[] miArray = new int[num];
            int[] arrayRelleno = rellenarArray(miArray);
            calculadora(arrayRelleno);
        }
        private static void calculadora(int[] miArray)
        {
            /* Realizamos solo la suma, para las demás operacones 
                se haría un switch para cada caso elegido */
            double resultado = 0;
            foreach (int array in miArray)
            {
                resultado += array;
            }
            Console.WriteLine("el resultado de la suma es: " + resultado);
        }

        private static int[] rellenarArray(int[] miArray)
        {

            for (int i = 0; i < miArray.Length; i++)
            {
                Console.WriteLine("Introduce el numero " + (i + 1));
                miArray[i] = int.Parse(Console.ReadLine());
            }
            return miArray;
        }
    
}
}
