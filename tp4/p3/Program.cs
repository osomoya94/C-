using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresá una frase (ejemplo: hola sucio:");
            string fraseOriginal = Console.ReadLine();

            char[] caracteres = fraseOriginal.ToCharArray();

            Array.Reverse(caracteres);

            string fraseInvertida = new string(caracteres);

            Console.WriteLine($"Resultado: {fraseInvertida}");
        }
    }
}
