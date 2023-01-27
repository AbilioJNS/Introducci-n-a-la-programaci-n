using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro1 = new Perro();
            Console.WriteLine(perro1.nombre + " " + perro1.edad + " " + perro1.tamaño);
            Perro chihui = new Chihuahua("marrón");
            Chihuahua chihui2 = new Chihuahua("gris");
            chihui.Ladrar();
            chihui2.Ladrar();
            Console.WriteLine(chihui2.GetEdad());
            Console.WriteLine(chihui2.tamaño);
            Console.WriteLine(chihui2.nombre);
        }

    }
    class Perro
    {
        public string nombre;
        public int edad;
        public string tamaño;

        public Perro(string nombre = "default", int edad = 0, string tamaño = "default")
        {
            this.nombre = nombre;
            this.edad = edad;
            this.tamaño = tamaño;
        }

        internal int GetEdad()
        {
            return ObtenerEdadPerruna(edad);
        }
        private int ObtenerEdadPerruna(int edad)
        {
            return edad * 7;
        }
        public void Ladrar()
        {
            Console.WriteLine("El perro esta ladrando");
        }
    }
    class Chihuahua:Perro 
    {
        public string color;
        public Chihuahua(string color,string nombre= "default", string tamaño="pequeño"):base(nombre,0,tamaño) 
        {
            this.color = color;
        }
        public void Ladrar() 
        { 
            Console.WriteLine("el Chihuahua esta ladrando"); 
        }
        
    }
}
