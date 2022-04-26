using System;
using Entidad;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador(); 

            Console.WriteLine($"La suma de dos long {sumador.Sumar(48, 2)}");
            Console.WriteLine($"La suma de dos string {sumador.Sumar("Hola ", "Mundo")}");


        }
    }
}
