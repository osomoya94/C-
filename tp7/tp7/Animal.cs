using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7
{
    class Animal
    {
        private string nombre;
        private string alimento;
        private int edad;
        private string raza;

        public Animal( string nombre,string alimento,int edad,string raza) 
        {
            this.nombre = nombre;
            this.alimento = alimento;
            this.edad = edad;
            this.raza = raza;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetAlimento() 
        {
            return this.alimento;
        }

        public int GetEdad() 
        {
            return this.edad;
        }

        public string GetRaza() 
        {
            return this.raza;
        }
        //public void SetNombre(string nuevoNombre)
        //{
        //    this.nombre = nuevoNombre;
        //}
        public virtual void seAlimenta() 
        {
            Console.WriteLine("EL animal se aliementa");
        }
    }
}
