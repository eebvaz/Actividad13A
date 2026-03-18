using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            int cant;
            Console.WriteLine("Ingrese cantidad de empleados:");
            cant = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= cant; i++)
            {
                Empleado empleado = new Empleado();

                Console.WriteLine("Nombre:");
                empleado.nombre = Console.ReadLine();

                Console.WriteLine("Puesto:");
                empleado.puesto = Console.ReadLine();

                Console.WriteLine("Salario mensual:");
                empleado.salario = double.Parse(Console.ReadLine());

                empleados.Add(empleado);
                Console.Clear();
            }

            foreach (Empleado item in empleados)
            {
                item.MostrarDatos();
            }

        }
    }
}


class Empleado
{
    public string nombre;
    public string puesto;
    public double salario;


    public double Sueldo()
    {
            return salario * 12;
    }

    public double Bono()
    {


        return (salario * 12) / 12;

    }

    public string Clasificacion()
    {
        if (salario >= 5000) 
         { 
            return "Alto"; 
        }
        else if (salario >= 3000) 
        {
            return "Medio";
        }
        else 
         {
            return "Basico";
        }
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {nombre} | Puesto: {puesto} | Salario: Q{salario} | Anual: Q{Sueldo()} | Bono: Q{Bono()} | Tipo: {Clasificacion()}");
    }



}