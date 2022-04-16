using System;

namespace Factorial
{
    public class Factorial
    {
        public static int Calcular(int numero)
        {
            int factorial = numero;

            for (int i = numero - 1; i > 0; i--)
            {

                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
