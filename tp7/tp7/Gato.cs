using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7
{
    class Gato: Animal
    {
        public Gato(string nombre, string alimento, int edad, string raza):base(nombre,alimento,edad,raza)
        {
        }


        public override void seAlimenta()
        {
            Console.WriteLine($"EL gato {this.GetNombre()} se alimenta con {this.GetAlimento()}");
        }
    }
}
