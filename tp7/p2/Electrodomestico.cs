using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class Electrodomestico
    {
        private int precio;
        private string color;
        private char consumo;
        private int peso;

        public Electrodomestico()
        {
            this.precio = 100; 
            this.color = "blanco";
            this.consumo = 'F';
            this.peso = 5;
        }

        public Electrodomestico(int precio, string color, char consumo, int peso)
        {
            this.precio = precio;
            this.color = comprobarColor(color);
            this.consumo = comprobarConsumoEnergetico(consumo);
            this.peso = peso;
        }

        public int getPrecio() { return precio; }
        public string getColor() { return color; }
        public char getConsumo() { return consumo; }
        public int getPeso() { return peso; }

        public void setPrecio(int precio) {this.precio = precio;}
        public void setColor(string color) {this.color = color;}
        public void serConsumo(char consumo) { this.consumo = consumo;}
        public void setPeso(int peso) { this.peso = peso;}

        private char comprobarConsumoEnergetico(char letra)
        {
            char letraMayuscula = Char.ToUpper(letra);

            if (letraMayuscula >= 'A' && letraMayuscula <= 'F')
            {
                return letraMayuscula;
            }
            else
            {
                return 'F'; 
            }
        }

        private string comprobarColor(string color) {
            string nuevoColor = color.ToLower();

            if (nuevoColor == "blanco")
            {
                return nuevoColor;
            }
            else if (nuevoColor == "negro")
            {
                return nuevoColor;
            }
            else if (nuevoColor == "rojo")
            {
                return nuevoColor;
            }
            else if (nuevoColor == "azul")
            {
                return nuevoColor;
            }
            else if (nuevoColor == "gris")
            {
                return nuevoColor;
            }
            else
            {
                nuevoColor = "blanco";

                return nuevoColor;
            }
        }

        public virtual int precioFinal()
        {
            int valorLetra = 0;
            int valorPeso = 0;

            if (this.consumo == 'A') { valorLetra = 1000; }
            else if (this.consumo == 'B') { valorLetra = 800; }
            else if (this.consumo == 'C') { valorLetra = 600; }
            else if (this.consumo == 'D') { valorLetra = 500; }
            else if (this.consumo == 'E') { valorLetra = 300; }
            else { valorLetra = 100; }

            if (this.peso >= 1 && this.peso <= 19) { valorPeso = 100; }
            else if (this.peso >= 20 && this.peso <= 49) { valorPeso = 500; } // Era 20, no 10
            else if (this.peso >= 50 && this.peso <= 79) { valorPeso = 800; }
            else { valorPeso = 1000; } 

            return this.precio + valorLetra + valorPeso;
        }

    }
}
