using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Electrodomestico miLavadora = new Lavadora(1000, "gris", 'A', 55, 35);

         
            Electrodomestico miTele = new Televisor(2000, "negro", 'C', 15, 50, true);

            Console.WriteLine($"El precio final de la Lavadora es: ${miLavadora.precioFinal()}");
            Console.WriteLine($"El precio final del Televisor es: ${miTele.precioFinal()}");

            Console.ReadLine(); 
        }
    }
}
