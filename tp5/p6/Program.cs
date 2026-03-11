using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p6
{
    internal class Program
    {
        
        static void MostarConGuiones(string texto)
        {
            string textoFinal = "";
            foreach (char letra in texto)
            {
                textoFinal = textoFinal + letra + "-";
            }

            textoFinal = textoFinal.Substring(0, textoFinal.Length - 1);

            Console.WriteLine(textoFinal);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese El texto");
            string texto = Console.ReadLine();
            MostarConGuiones (texto);
        }
    }
}
