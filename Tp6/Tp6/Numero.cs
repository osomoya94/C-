using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6
{
    internal class Numero
    {
        public int entero;

        public Numero(int entero) 
        {
            this.entero = entero;
        }

        public int getEntero()
        {
            return entero;
        }

        public void setEntero(int entero) 
        {  
            this.entero = entero; 
        }

        public bool esPar() 
        {
            if (this.entero % 2 == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool esPositivo()
        {
            if (this.entero >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool esMultiploDe(int n) 
        {
            if (this.entero % n == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
