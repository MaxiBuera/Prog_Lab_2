using System;
using Prestamo;

namespace CreoQueNecesitoUnPrestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("PedroAlfonso", 124);

            Console.WriteLine($"{cuenta1.Mostrar()}");
            Console.WriteLine($"Se acredita $1");
            Cuenta.Ingresar(cuenta1, 1);
            Console.WriteLine($"{cuenta1.Mostrar()}");
            Console.WriteLine($"Se retira $5");
            Cuenta.Retirar(cuenta1, 5);
            Console.WriteLine($"{cuenta1.Mostrar()}");
        }
    }
}
