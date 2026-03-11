using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4
{
    internal class Program
    {
        public struct Materias
        {
            public string nombrMateria;
            public string modalidad;
            public int anio;
        }
        public struct alumno
        {
            public string apellido;
            public string nombre;
            public int dni;
            public Materias[] materias;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos alumnos desea ingresar?");
            int cantidadAlumnos = int.Parse(Console.ReadLine());

            alumno[] alumnos = new alumno[cantidadAlumnos];

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine($"Ingrese el apellido del alumno {i + 1}:");
                alumnos[i].apellido = Console.ReadLine();
                Console.WriteLine($"Ingrese el nombre del alumno {i + 1}:");
                alumnos[i].nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese el DNI del alumno {i + 1}:");
                alumnos[i].dni = int.Parse(Console.ReadLine());

         
                int cantidadMaterias=0;
                Console.WriteLine("Cuantas materias se desea inscribir? solo puede un maximo de 3 materias");
                cantidadMaterias = int.Parse(Console.ReadLine());

                while (cantidadMaterias > 3 || cantidadMaterias < 0)
                {
                    Console.WriteLine("Cantidad invalida, la cantidad debe ser entre 0 y 3");
                    cantidadMaterias = int.Parse(Console.ReadLine());
                }



                alumnos[i].materias = new Materias[cantidadMaterias];

                for (int j = 0; j < cantidadMaterias; j++) 
                {
                    Console.WriteLine($"Ingrese el nombre de la materia {j + 1}:");
                    alumnos[i].materias[j].nombrMateria = Console.ReadLine();

                    Console.WriteLine($"Ingrese la modalidad de la materia {j + 1}:");
                    alumnos[i].materias[j].modalidad = Console.ReadLine();

                    Console.WriteLine($"Ingrese el año de la materia {j + 1}:");
                    alumnos[i].materias[j].anio = int.Parse(Console.ReadLine());
                }

            }


            foreach (var alumno in alumnos)
            {
                Console.WriteLine($"Alumno: {alumno.nombre} {alumno.apellido}, DNI: {alumno.dni}");
                Console.WriteLine("Materias inscritas:");
                foreach (var materia in alumno.materias)
                {
                    Console.WriteLine($"- {materia.nombrMateria}, Modalidad: {materia.modalidad}, Año: {materia.anio}");
                }
            }
        }
    }
}
