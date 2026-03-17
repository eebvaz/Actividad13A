using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiante = new List<Estudiante>();
            int cant;


            Console.WriteLine("Ingrese la cantidad de estudiantes a añadir: ");
            cant = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i <= cant; i++)
            {
                Console.Clear();

                Estudiante alumno = new Estudiante();

                Console.WriteLine("Nombre del alumno: ");
                alumno.nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la nota1: ");
                alumno.nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la nota2: ");
                alumno.nota2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la nota3: ");
                alumno.nota3 = double.Parse(Console.ReadLine());
                estudiante.Add(alumno);

            }

            Console.Clear();
            Console.ReadKey();

            double sumatoria = 0;
            Estudiante muesta = estudiante[0];
            Console.WriteLine("LISTA DE ESTUDIANTES");
            foreach (Estudiante item in estudiante)
            {
                item.MostrarDatos();

                sumatoria = sumatoria + item.CalcularPromedio();

                if (item.CalcularPromedio() > muesta.CalcularPromedio())
                {
                    muesta = item;
                }
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Promedio de los alumnos: " + sumatoria / estudiante.Count);
            Console.WriteLine("Mejor resultado: ");
            muesta.MostrarDatos();
        }
    }
}


class Estudiante
{
    public string nombre;
    public double nota1;
    public double nota2;
    public double nota3;


    public double CalcularPromedio()
    {
        return (nota1 + nota2 + nota3) / 3;
    }
    public string Aprobacion()
    {
        if (CalcularPromedio() >= 61)
        {
            return "Aprobado";
        }
        else
        {
            return "Reprobado";
        }
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre:  {nombre}  | Promedio:   {CalcularPromedio():F2}  | Estado:  {Aprobacion():F2}");
    }

}

