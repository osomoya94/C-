using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    internal class Program
    {
        
        static bool esPrimo(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0) return false;

            int limite = (int)Math.Sqrt(n);
            for (int i = 3; i <= limite; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int n = int.Parse(Console.ReadLine());

            bool result = esPrimo(n);

            if(result == true)Console.WriteLine($"El numerno {n} es primo");
            if (result == false) Console.WriteLine($"El numerno {n} no es primo");


        }
    }
}
