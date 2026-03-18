using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Libro> libros = new List<Libro>();

            int cant;
            Console.WriteLine("Cantidad de libros:");
            cant = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= cant; i++)
                {

                Libro cuadernos = new Libro();

                Console.WriteLine("Titulo:  ");
                cuadernos.titulo = Console.ReadLine();

                Console.WriteLine("Autor:  ");
                cuadernos.autor = Console.ReadLine();

                Console.WriteLine("Categoria:   ");
                cuadernos.categoria = Console.ReadLine();

                Console.WriteLine("Paginas:  ");
                cuadernos.paginas = int.Parse(Console.ReadLine());

                libros.Add(cuadernos);
                Console.Clear();


            }

            Libro mayor = libros[0];

            foreach (Libro item in libros)
            {
                item.Mostrar();

                if (item.paginas > mayor.paginas)
                {
                    mayor = item;
                }
            }

            Console.WriteLine("Libro con mayor cantidad de paginas:   ");
            mayor.Mostrar();


        }
    }
}
class Libro
{
    public string titulo;
    public string autor;
    public string categoria;
    public int paginas;

    public string Cantidad()
    {
        if (paginas < 100)
        {
            return "Corto";
        }
        else if (paginas <= 300)
        {
            return "Mediano";
        }
        else
        {
            return "Extenso";
        }
    }

    public void Mostrar()
    {
        Console.WriteLine($"Titulo: {titulo} | Autor: {autor} | Categoria: {categoria} | Paginas: {paginas} | Tipo: {Cantidad()}");
    }
}