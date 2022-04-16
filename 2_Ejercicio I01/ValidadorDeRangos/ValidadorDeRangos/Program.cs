using System;
using Validador;

namespace ValidadorDeRangos
{
    internal class Program
    {
        static int numero;
        static string numeroTexto;
        static bool esValido;
        private const int min = -100; //no hace falta ser static, al ya ser constante
        private const int max = 100;

        static int numeroMaximo = 0;
        static int numeroMinimo = 0;
        static int promedio = 0;

        static bool flag = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 10 numeros");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese el {0}º numero: ", i);
                numeroTexto = Console.ReadLine();
                _= int.TryParse(numeroTexto, out numero);
                esValido = Validador.Validador.Validar(numero, min, max);
                if (esValido)
                {
                    if (!flag)
                    {

                        numeroMaximo = numero;
                        numeroMinimo = numero;
                        flag = true;
                    }
                    else
                    {

                        if (numeroMaximo < numero)
                        {
                            numeroMaximo = numero;
                        }

                        if (numeroMinimo > numero)
                        {
                            numeroMinimo = numero;
                        }
                    }

                    //Promedio
                    promedio += numero;
                }
                else
                {
                    Console.WriteLine("Numero no valido. Vuelva a ingresar");
                }
            }

            Console.WriteLine("El numero maximo ingresado fue {0}", numeroMaximo);
            Console.WriteLine("El numero minimo ingresado fue {0}", numeroMinimo);
            Console.WriteLine("El promedio de los numeros ingresados fue {0}", promedio / 10);
        }
    }
}
