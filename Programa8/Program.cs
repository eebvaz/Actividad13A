using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Cuenta> cuentas = new List<Cuenta>();

            int cant;

            Console.WriteLine("Ingrese la cantidad de cuentas:");
            cant = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= cant; i++)
            {
                Cuenta cuentaBancaria = new Cuenta();
                Console.Clear();
                Console.WriteLine("Titular:");
                cuentaBancaria.titular = Console.ReadLine();

                Console.WriteLine("Saldo inicial:");
                cuentaBancaria.saldo = double.Parse(Console.ReadLine());

                cuentas.Add(cuentaBancaria);

            }

            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
            foreach (Cuenta item in cuentas)
            {
                double depositar1, retirar1;

                int opcion=0;

                Console.WriteLine("Ingrese su opcion: ");
                Console.WriteLine("Opcion 1; depositar");
                Console.WriteLine("Opcion 2: retirar");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Deposito: Q");
                    depositar1 = double.Parse(Console.ReadLine());
                    item.Depositar(depositar1);

                }
                else
                {
                    Console.Write("Retiro: Q");
                    retirar1 = double.Parse(Console.ReadLine());
                    item.Retirar(retirar1);

                }


       
            }
            Console.ReadKey();
            Console.Clear();

            foreach (Cuenta item in cuentas)
            {
                item.MostrarDatos();
            }

        }
    }
}
class Cuenta
{
    public string titular;
    public double saldo;

    public void Depositar(double monto)
    {
        saldo += monto;
    }

    public void Retirar(double monto)
    {
        saldo -= monto;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Titular: {titular} | Saldo final: {saldo}");
    }
}