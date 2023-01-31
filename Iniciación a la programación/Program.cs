using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Iniciación_a_la_programación
{
    class Program
    {
        enum estaciones {
            Verano = 6,
            Otoño = 10,
            Primavera = 4,
            Invierno = 1
        }
        struct persona {
            public string nombre;
            public string apellido;
            public int edad;
            public string sexo;
        }

        struct cancion
        {
            public string artista;
            public string titulo;
            public int duracion;
            public float tamaño;
        }

        struct tipoDeVariable 
        { 
            public int anyo;
            public int meses;
            public int semanas;
        }

        public static void Main(string[] args)
        {
            bool repetir = true;

            while (repetir)
            {
                
                recordarTabla();
                Console.WriteLine("Quiere recordar alguna otra tabla true/false");
                string rep = Console.ReadLine();
                repetir = rep.Equals("true");
            } 
           

        /** Imprime por pantalla los numeros consecutivos hasta el introducido
            Console.WriteLine("Hasta que nº quieres contar?");
            int num = int.Parse(Console.ReadLine());
            int n = 0;
            while(n<=num)
            {
                Console.WriteLine("Esta es n " + n);   
                n++;
            }
            
            n = 0;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("esta es i " +i);
            }*/

        /**Calcula número mayor que otro o igual y si son pares
                 * 
                    Console.WriteLine("Introduce el primer número");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el segundo número");
                    int num2 = int.Parse(Console.ReadLine());

                    bool mayor1 = num1 > num2;
                    bool mayor2 = num1 < num2;
                    bool numIguales = num1 == num2;
                    bool parNum1 = num1 % 2 == 0;
                    bool parNum2 = num2 % 2 == 0;

                    Console.WriteLine("¿El numero 1 es mayor que el numero 2? " + mayor1);
                    Console.WriteLine("¿El numero 2 es mayor que el numero 1? " + mayor2);
                    Console.WriteLine("¿Son iguales los números? " + numIguales);
                    Console.WriteLine("¿El número 1 es par? " + parNum1 + " ¿o es par el número 2? "+ parNum2);*/

        /**Clacula años,semanas,dias
                 * **/
                //tipoDeVariable laVariable;
                //laVariable.anyo = 0;
                //laVariable.meses = 0;
                //laVariable.semanas = 0;
                //Console.WriteLine("introduce numero de dias");
                //int numDias = int.Parse(Console.ReadLine());
                //while(numDias >= 365)
                //{
                //    laVariable.anyo++;
                //    numDias = numDias - 365;
                //}
                //while (numDias >= 30) 
                //{
                //    laVariable.meses++;
                //    numDias= numDias - 30;
                //}
                //while (numDias >= 7) 
                //{
                //    laVariable.semanas++;
                //    numDias= numDias - 7;
                //}
                //Console.WriteLine($"Tenemos {laVariable.anyo} años, {laVariable.meses} meses y {numDias} dias");

        /**Añadir cancion a struct**/
                //cancion song;
                //Console.WriteLine("Introduce titulo canción");
                //song.titulo = Console.ReadLine();
                //Console.WriteLine("Introduce nombre del artista");
                //song.artista = Console.ReadLine();
                //Console.WriteLine("Introduce duración de la canción");
                //song.duracion = Int32.Parse(Console.ReadLine());
                //Console.WriteLine("Introduce tamaño de la canción");
                //song.tamaño = float.Parse(Console.ReadLine());

                //Console.WriteLine($"Mi cancion es {song.titulo} del artista {song.artista} " +
                //    $"que dura {song.duracion} y pesa {song.tamaño}");



        /** Añadir personas a un array de struct */
                //persona persona1;
                //string edadletra = Console.ReadLine();
                //int edad = Int32.Parse(edadletra);
                //persona1.edad = edad;
                //persona[] personas = new persona[3];
                //Console.WriteLine("introduce tu nombre");
                ////string nombre = Console.ReadLine();
                //personas[0].nombre = "Abilio";
                //personas[0].apellido = "Navarro";
                //personas[0].edad = 36;
                //personas[0].sexo = "Varón";

                //personas[1].nombre = "Pepito";
                //personas[1].apellido = "Garcia";
                //personas[1].edad = 55;
                //personas[1].sexo = "Varón";

                //personas[2].nombre = "Rosa";
                //personas[2].apellido = "Gomez";
                //personas[2].edad = 22;
                //personas[2].sexo = "Mujer";

                //Console.WriteLine($"El nombre de las tres personas es: {personas[0].nombre} " +
                //    $"{personas[1].nombre} {personas[2].nombre}");


         /** Argumento o parametro pasado por referencia o por valor */
                //int[] arrayUnidimensional = {1,2, 3, 4,5};
                //Console.WriteLine(arrayUnidimensional);
                //Ejemplo para referencia o valor
                //LaClase clase = new LaClase();
                //LaEstructura estructura = new LaEstructura();

                //clase.variableClase = "No cambiado";
                //estructura.variableEstructura = "No cambiado";

                //TestDeClaseYEstructura test = new TestDeClaseYEstructura();

                //test.CambiarClase(clase);
                //test.CambiarEstructura(estructura);

                //Console.WriteLine(clase.variableClase);
                //Console.WriteLine(estructura.variableEstructura);


        }

        private static void recordarTabla()
        {
            Console.WriteLine("¿Que tabla quieres repasar? *Introduzca -1 para salir* ");
            int tabla = Math.Abs(int.Parse(Console.ReadLine()));
            int[] numTabla = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in numTabla)
            {
                Console.WriteLine($"{tabla} x {i} = {i * tabla}");
            }
        }
    }
    
}
