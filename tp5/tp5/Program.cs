using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    internal class Program
    {
        static void mostrarMensaje()
        {
            Console.WriteLine("ingrese un la las siguientes opciones para ingresar");
            Console.WriteLine(" 1: suma");
            Console.WriteLine(" 2: resta");
            Console.WriteLine(" 3: multiplicacion");
            Console.WriteLine(" 4: divicion");
            Console.WriteLine(" 0: salir");
        }

        static void operaciones(int op,int n1, int n2)
        {
            switch (op) 
            {
                case 1:
                    int suma = n1 + n2;
                    Console.WriteLine($"EL resultado de la suma es: {suma}");
                    break;
                case 2:
                    int resta = n1 - n2;
                    Console.WriteLine($"EL resultado de la resta es: {resta}");
                    break;
                case 3:
                    int mult = n1 * n2;
                    Console.WriteLine($"EL resultado de la multiplicacion es: {mult}");
                    break;
                case 4:
                    int div = n1 / n2;
                    Console.WriteLine($"EL resultado de la division es: {div}");
                    break;
            }
        }

        static void Main(string[] args)
        {
             mostrarMensaje();
            int opcion = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 0;
            bool interasion = false;


            while (opcion < 0 || 5<opcion)
            {
                Console.WriteLine("Opcion no valida");
                mostrarMensaje();
                opcion = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());


            do
            {
                if(opcion == 4) 
                {
                    if (n2 == 0)
                    {
                        Console.WriteLine("El segundo numero tiene que ser distino de 0, ingrese un numero de nuevo");
                        n2 = int.Parse(Console.ReadLine());
                        interasion = true;
                    }else
                    {
                        interasion= false;
                    }
                }
            }
            while (interasion);


            operaciones(opcion, n1, n2);




        }
    }
}
