using System;
using System.Collections.Generic;
using LaCalculadoraDeFormas;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            lista.Add(new Cuadrado(4));
            lista.Add(new Circulo(5));
            lista.Add(new Rectangulo(2, 3));

            foreach (Figura figura in lista)
            {

                Console.WriteLine($"Tipo: {figura.GetType().Name}");
                Console.WriteLine($"{figura.Dibujar()}");
                Console.WriteLine($"Area: {figura.CalcularSuperficie()}");
                Console.WriteLine($"Perimetro: {figura.CalcularPerimetro()}");
                Console.WriteLine($"\n");
            }
        }
    }
}
