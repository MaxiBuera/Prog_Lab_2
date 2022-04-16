using System;
using Factorial;
namespace CalcularUnFactorial
{
    internal class Program
    {
        static int numero;
        static string numeroTexto;
        static bool numeroValido;
        static int resultado;

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el un numero: ");
            numeroTexto = Console.ReadLine();
            numeroValido = int.TryParse(numeroTexto, out numero);

            if (numeroValido)
            {
                resultado = Factorial.Factorial.Calcular(numero);
                Console.WriteLine("El factorial de {0} es: {1}", numero, resultado);
            }
        }
    }
}
