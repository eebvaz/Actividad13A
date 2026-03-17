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
        string resultado = "";



        return resultado;

    }



}