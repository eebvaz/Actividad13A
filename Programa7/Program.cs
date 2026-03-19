using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Producto> productos = new Dictionary<string, Producto>();

            int cant;

            Console.WriteLine("");
            Console.WriteLine("Ingrese la cantidad de productos: ");
            cant = int.Parse(Console.ReadLine());
            Console.Clear();


            for (int i = 1; i <= cant; i++)
            {
                Producto mercancia = new Producto();
                Console.Clear();
                Console.WriteLine("Codigo del producto:");
                string codigo = Console.ReadLine();

                Console.WriteLine("Nombre del producto: ");
                mercancia.nombre = Console.ReadLine();

                Console.WriteLine("Precio: ");
                mercancia.precio = double.Parse(Console.ReadLine());

                Console.WriteLine("Cantidad: ");
                mercancia.cantidad = int.Parse(Console.ReadLine());

                productos.Add(codigo, mercancia);

              
            }

            Console.WriteLine("");
            Console.ReadKey();

            double sumatoria = 0;


            Producto elementos = productos.First().Value;

            foreach (var item in productos)
            {
                Console.WriteLine("Codigo: " + item.Key);
                item.Value.MostrarDatos();

                sumatoria = sumatoria + item.Value.CalcularValor();

                if (item.Value.CalcularValor() > elementos.CalcularValor())
                {
                    elementos = item.Value;
                }
            }

            Console.Clear();
            Console.WriteLine("Valor total del inventario: Q" + sumatoria);
            Console.WriteLine("Producto con mayor valor:");
            elementos.MostrarDatos();


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ingrese codigo a buscar:");
            string buscar = Console.ReadLine();

            if (productos.ContainsKey(buscar))
            {
                productos[buscar].MostrarDatos();
            }
            else
            {
                Console.WriteLine("Producto no encontrado");
            }



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
        string resultado = "";

        if (cantidad == 0)
        {
            resultado = "Sin Existencias";
        }
        else if (cantidad < 20)
        {
            resultado = "Stock bajo";
        }
        else
        {
            resultado = "Stock suficiente";
        }

        return resultado;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {nombre} | Precio Q: {precio:F2} | Stock: {cantidad} | Estado: {DeterminarEstado()}");
    }
}