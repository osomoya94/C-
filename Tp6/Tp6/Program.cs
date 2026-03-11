using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numero n1 = new Numero(1459);
       
            Console.WriteLine($"El numero {n1.getEntero()} es para? " + n1.esPar());
            Console.WriteLine($"El numero {n1.getEntero()} es positivo? "+ n1.esPositivo());
            Console.WriteLine($"El numero {n1.getEntero()} es multiplo de {3}? " + n1.esMultiploDe(3));

        }
    }
}
