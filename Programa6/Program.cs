using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Estudiante> estudiantes = new Dictionary<string, Estudiante>();


            int cant;
            Console.WriteLine("Cantidad:  ");
            cant = int.Parse(Console.ReadLine());


            for (int i = 0; i < cant; i++)
            {
                Console.Clear();
                Estudiante alumno = new Estudiante();

                Console.Write("Carnet: ");
                string carnet = Console.ReadLine();

                Console.Write("Nombre: ");
                alumno.nombre = Console.ReadLine();

                Console.Write("Carrera: ");
                alumno.carrera = Console.ReadLine();

                Console.Write("Nota final: ");
                alumno.nota = double.Parse(Console.ReadLine());

                estudiantes.Add(carnet, alumno);
            }

            Console.ReadKey();
            Console.Clear();

            foreach (var item in estudiantes)
            {
                Console.WriteLine("Carnet: " + item.Key);
                item.Value.Mostrar();
            }

            Console.ReadKey();
            Console.Clear();    
            Console.Write("Buscar carnet: ");
            string buscar = Console.ReadLine();



            if (estudiantes.ContainsKey(buscar))
            {
                estudiantes[buscar].Mostrar();
            }
            else
            {
                Console.WriteLine("No encontrado");
            }



        }
    }
}


class Estudiante
{
    public string nombre;
    public string carrera;
    public double nota;

    public string Estado()
    {
        if (nota >= 61)
        {
            return "Aprobado";
        }
        else
        {
            return "Reprobado";
        }
    }

    public void Mostrar()
    {
        Console.WriteLine($"Nombre: {nombre} | Carrera: {carrera} | Nota: {nota} | Estado: {Estado()}");
    }


}