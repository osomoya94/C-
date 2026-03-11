using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    internal class Cuadrilatero
    {
        private int largo;
        private int alto;

        public Cuadrilatero(int largo, int alto) 
        {
            this.largo = largo;
            this.alto = alto;
        }

        public int getLargo() 
        {
            return largo;
        }

        public int getAlto() 
        {
            return alto;
        }

        public void setLargo(int largo) 
        {
            this.largo = largo;
        }

        public void setAlto(int alto)
        {
            this.alto = alto;
        }

        public void calcularPerimetro() 
        {
            int total = 2 * (this.largo+this.alto);
            Console.WriteLine($"El perimetro del cuadrilatero es : {total} ");
        }

        public void calcularAre() 
        {
            int area = this.alto * this.largo;
            Console.WriteLine($"La superficie del cuadratico es {area}");
        }

        public bool esUnCuadrado() 
        {
            if (this.largo == this.alto)
            {
                return true;
            }
            return false;
        }





    }
}
