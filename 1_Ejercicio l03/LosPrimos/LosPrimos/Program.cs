using System;

namespace LosPrimos
{
    static class Program
    {
        static bool esPrimo(int numero)
        {
            // Casos especiales
            if (numero == 0 || numero == 1 || numero == 4) return false;
            for (int x = 2; x < numero / 2; x++)
            {
                if (numero % x == 0) return false;
            }
            // Si no se pudo dividir por ninguno de los de arriba, sí es primo
            return true;
        }

        static void Main(string[] args)
        {
            int numero;
            string numeroTexto;
            bool numeroValidado;
            bool continuar = true;
            int opcion;
            string opcionTexto;

            Console.WriteLine("Ingrese un numero: ");

            do
            {
                numeroTexto = Console.ReadLine();
                numeroValidado = int.TryParse(numeroTexto, out numero);

                if (esPrimo(numero))
                {
                    for (int x = numero; x >= 2; x--)
                    {
                        if (esPrimo(x))
                            Console.Write("{0} - ", x);

                    }
                } else
                {
                    Console.WriteLine("No es un numero primo");
                }


                if (!numeroValidado)
                {
                    Console.WriteLine("Numero invalido. Vuelva a ingresar: ");
                }

                Console.WriteLine("\n\nDesea volver a operar?");
                Console.WriteLine("\n1) Continuar\n2) Salir\n");
                opcionTexto = Console.ReadLine();
                _ = int.TryParse(opcionTexto, out opcion);
                if (opcion == 2)
                {
                    continuar = false;
                }
            } while (!numeroValidado || continuar);


        }
    }
}
