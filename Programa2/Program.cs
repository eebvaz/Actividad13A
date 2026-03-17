using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();

            int cant;

            Console.WriteLine("");
            Console.WriteLine("Ingrese la cantidad de productos: ");
            cant = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= cant; i++)
            {
                Producto mercancia = new Producto();
                Console.Clear();
                Console.WriteLine("Nombre del producto");
                mercancia.nombre = Console.ReadLine();
                Console.WriteLine("Precio: ");
                mercancia.precio = double.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                mercancia.cantidad = int.Parse(Console.ReadLine());

                productos.Add(mercancia);

            }

            Console.Clear() ;

            Console.WriteLine("");
            Console.ReadKey();
            double sumatoria = 0;
            Producto elementos = productos[0];

            foreach (Producto item in productos)
            {
                item.MostrarDatos();

                sumatoria = sumatoria + item.CalcularValor();

                if (item.CalcularValor() > item.CalcularValor())
                {
                    elementos = item;
                }

            }

            Console.Clear();
            Console.WriteLine("Valor total del inventario: Q" + sumatoria);
            Console.WriteLine("Mayor precio: ");
            elementos.MostrarDatos();

        }
    }
}


class Producto
{
    public string nombre;
    public double precio;
    public int cantidad;


    public double CalcularValor()
    {
        return precio * cantidad;
    }

    public string DeterminarEstado()
    {

        string resultado="";


        if (cantidad >= 50)
        {
            resultado = "Stocks suficiente";
        }
        else if (cantidad < 20)
        {
            resultado = "Stocks bajos";
        }
        else if (cantidad == 0)
        {
            resultado = "Sin Existencias";
        }
       

        return resultado;
    }


    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre:  {nombre}  | Precio Q:   {precio:F4}  | Cantidad:  {cantidad}  | Estado:  {DeterminarEstado()}");
    }

}