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
            Cuadrilatero c1 = new Cuadrilatero(2,2);

            c1.calcularPerimetro();
            c1.calcularAre();
            Console.WriteLine("Es cuadrado? : "+ c1.esUnCuadrado());
            
        }
    }
}
