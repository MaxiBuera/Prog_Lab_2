using System;

namespace ErrorAlCubo
{

    class Program
    {

        static void Main(string[] args)
        {
            int numero;
            string numeroTexto;

            Console.WriteLine("Ingrese un numero: ");

            do
            {
                numeroTexto = Console.ReadLine();
                int.TryParse(numeroTexto, out numero);
                if (numero < 0)
                {

                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            } while (numero < 0);

            Console.WriteLine("El cuadrado de {0} es: {1} ", numero, Math.Pow(numero, 2));
            Console.WriteLine("El cubo de {0} es: {1}", numero, Math.Pow(numero, 3));

        }
    }
}