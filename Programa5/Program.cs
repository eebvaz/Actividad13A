using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Venta> ventas = new List<Venta>();

            int cant;
            Console.WriteLine("Ingrese su compra: ");
            cant = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= cant; i++)
            {
                Venta vendedido = new Venta();

                Console.WriteLine("Producto: ");
                vendedido.producto = Console.ReadLine();

                Console.WriteLine("Precio: ");
                vendedido.precio = double.Parse(Console.ReadLine());

                Console.WriteLine("Cantidad: ");
                vendedido.cantidad = int.Parse(Console.ReadLine());

                ventas.Add(vendedido);
                Console.Clear();
            }

            double total = 0;

            foreach (Venta item in ventas)
            {
                item.Mostrar();
                total = total + item.Total();
            }

            Console.WriteLine("Total generado vendido: " + total);

        }
    }
}
class Venta
{
    public string producto;
    public double precio;
    public int cantidad;

    public double Subtotal()
    {
        return precio * cantidad;
    }

    public double Descuento()
    {
        if (Subtotal() > 500)
            {
            return Subtotal() * 0.10;
             }
        else
        {
            return 0;
        }
    }

    public double Total()
    {
        return Subtotal() - Descuento();
    }

    public void Mostrar()
    {
        Console.WriteLine($"Producto: {producto} | Total: Q{Total()}");
    }
}