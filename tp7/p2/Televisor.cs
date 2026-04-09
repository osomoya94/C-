using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class Televisor : Electrodomestico
    {
        private int resolucion;
        private bool sintonizadorTDT;

        public Televisor() : base()
        {
            this.resolucion = 20;
            this.sintonizadorTDT = false;
        }

        public Televisor(int precio, string color, char consumo, int peso, int resolucion, bool sintonizadorTDT) : base(precio, color, consumo, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        public int getResolucion() { return this.resolucion; }
        public void setResolucion(int resolucion) { this.resolucion = resolucion; }

        public bool getSintonizadorTDT() { return this.sintonizadorTDT; }
        public void setSintonizadorTDT(bool sintonizadorTDT) { this.sintonizadorTDT = sintonizadorTDT; }

        public override int precioFinal()
        {
            int precioAcumulado = base.precioFinal();

            if (this.resolucion > 40)
            {
                precioAcumulado = precioAcumulado + (int)(precioAcumulado * 0.30);
            }

            if (this.sintonizadorTDT == true)
            {
                precioAcumulado = precioAcumulado + 500;
            }

            return precioAcumulado;
        }
    }
}
