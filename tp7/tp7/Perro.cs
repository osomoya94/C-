using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7
{
    internal class Perro:Animal
    {
        public Perro(string nombre, string alimento, int edad, string raza) : base(nombre, alimento, edad, raza)
        {
        }


        public override void seAlimenta()
        {
            Console.WriteLine($"EL perro {this.GetNombre()} se alimenta con {this.GetAlimento()}");
        }
    }
}
