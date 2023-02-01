using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TratamientoCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu frase");
            int aes = 0;
            string frase = Console.ReadLine();
            89574837 % 23 = 7
            for (int i=0; i < frase.Length; i++)
            {
                if (frase[i].Equals('a') || frase[i].Equals('A')) {
                    Console.WriteLine("aqui");
                    aes++;
                }
            }
            Console.WriteLine($"Tu frase tiene {aes} aes");
        }
    }
}
