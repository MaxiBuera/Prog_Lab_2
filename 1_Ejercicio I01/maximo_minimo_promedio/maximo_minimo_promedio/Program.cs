using System;

namespace maximo_minimo_promedio
{

    class Program
    {

        static void Main(string[] args)
        {
            int numero;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            int promedio = 0;
            bool flag = false;
            string numeroTexto;

            Console.WriteLine("Ingrese 5 numeros");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese el {0}º numero: ", i);
                numeroTexto = Console.ReadLine();
                int.TryParse(numeroTexto, out numero);
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
            };

            Console.WriteLine("El numero maximo ingresado fue {0}", numeroMaximo);
            Console.WriteLine("El numero minimo ingresado fue {0}", numeroMinimo);
            Console.WriteLine("El promedio de los numeros ingresados fue {0}", promedio / 5);
        }
    }
}


