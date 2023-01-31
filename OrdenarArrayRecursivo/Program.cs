using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarArrayRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayVacio = new int[5];
            int[] arrayConDatos = rellenar(arrayVacio);
            Console.WriteLine("Numeros sin ordenar");
            imprimirArray(arrayConDatos);
            Console.WriteLine("\n");
            int[] arrayOrdenado = ordenarArray(arrayConDatos, arrayConDatos.Length);
            Console.WriteLine("Numeros ordenados");
            imprimirArray(arrayOrdenado);
        }

        private static object crearObjeto()
        {
            return new object();
        }

        private static int[] ordenarArray(int[] arrayConDatos, int tamañoArray)
        {
            if (tamañoArray > 1) { 
                for (int i = 0; i < tamañoArray - 1; i++)
                {
                    if (arrayConDatos[i] > arrayConDatos[i + 1])
                    {
                        int aux = arrayConDatos[i + 1];
                        arrayConDatos[i + 1] = arrayConDatos[i];
                        arrayConDatos[i] = aux;
                    }
                }
                ordenarArray(arrayConDatos, tamañoArray - 1);
            }
            return arrayConDatos;
        }

        private static void imprimirArray(int[] arrayConDatos)
        {
            for (int i = 0; i < arrayConDatos.Length; i++)
            {
                Console.WriteLine(arrayConDatos[i]);
            }
        }
        private static int[] rellenar(int[] numerosAOrdenar)
        {
            Console.WriteLine("Introduzca 10 números aleatorios dando al" +
                " intro al introducir cada uno");
            for (int i = 0; i < numerosAOrdenar.Length; i++)
            {
                numerosAOrdenar[i] = int.Parse(Console.ReadLine());
            }
            return numerosAOrdenar;
        }
    }
}
