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
        Console.WriteLine($"Nombre:  {nombre}  | Promedio:   {CalcularPromedio():F2}  | :  {Aprobacion():F2}");
    }

}

