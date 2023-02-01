using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ValidarDNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("introduzca el dni a validar");
                string dniEntero = Console.ReadLine();
                string dniLetra = dniEntero.Substring(dniEntero.Length - 1);
                string dniNumero = dniEntero.Substring(0, dniEntero.Length - 1);
                string validarLetra = "TRWAGMYFPDXBNJZSQVHLCKE";
                foreach(char c in validarLetra) 
                {
                    Console.WriteLine(c);
                }
                
                if (dniLetra.Equals(Convert.ToString(validarLetra[calculaposicion(dniNumero)])))
                {
                    Console.WriteLine("dni Correcto");
                    break;
                }
                else 
                { 
                    Console.WriteLine("letra dni "+dniLetra+" letra validada "+ validarLetra[calculaposicion(dniNumero)]);
                    Console.WriteLine("Dni incorrecto");
                }
            }
        }

        private static int calculaposicion(string dniNumero)
        {
            
            return int.Parse(dniNumero) % 23;
        }
    }
}
