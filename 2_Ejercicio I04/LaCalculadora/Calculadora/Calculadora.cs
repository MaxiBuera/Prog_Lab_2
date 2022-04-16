using System;

namespace Calculadora
{
    public class Calculadora
    {
        public static int Calcular(int primeroOperando, int segundoOperando, char operacionMatematica)
        {
            int resultado = -1;

            switch (operacionMatematica)
            {
                case '+':
                    resultado = primeroOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primeroOperando - segundoOperando;
                    break;
                case '*':
                    resultado = primeroOperando * segundoOperando;
                    break;
                case '/':
                    if (Validar(segundoOperando))
                    {
                        resultado = primeroOperando / segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine("El segundo operando debe ser distinto de 0");
                    }
                    break;
            }
            return resultado;
        }

        public static bool Validar(int segundoOperando)
        {
            if (segundoOperando != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
