using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class Lavadora : Electrodomestico 
    {
        
        private int carga;

        public Lavadora() : base()
        {
            this.carga = 5; 
        }

        public Lavadora(int precio, string color, char consumo, int peso, int carga) : base(precio, color, consumo, peso)
        {
            this.carga = carga;
        }

        
        public int getCarga() { return this.carga; }
        public void setCarga(int carga) { this.carga = carga; }

        public override int precioFinal()
        {
            int precioAcumulado = base.precioFinal();

            if (this.carga > 30)
            {
                precioAcumulado = precioAcumulado + 500;
            }

            return precioAcumulado;
        }
    }
}
