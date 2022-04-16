using System;
using Calculadora;

namespace LaCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeroOperando;
            string primeroOperandoTexto;
            int segundoOperando;
            string segundoOperandoTexto;
            char operacionMatematica;
            string operacionMatematicaTexto;
            char continuar = 's';
            string continuarTexto;
            int resultado;

            while (continuar == 's')
            {

                Console.Write("Ingrese el primer operando: ");
                primeroOperandoTexto = Console.ReadLine();
                _ = int.TryParse(primeroOperandoTexto, out primeroOperando);

                Console.Write("Ingrese el segundo operando: ");
                segundoOperandoTexto = Console.ReadLine();
                _ = int.TryParse(segundoOperandoTexto, out segundoOperando);

                Console.WriteLine("Ingrese la operacion matematica: ");
                Console.WriteLine(" + (suma) | - (resta) | * (multiplicacion) | / (division): ");
                operacionMatematicaTexto = Console.ReadLine();
                _ = char.TryParse(operacionMatematicaTexto, out operacionMatematica);

                resultado = Calculadora.Calculadora.Calcular(primeroOperando, segundoOperando, operacionMatematica);

                Console.WriteLine("Resultado: {0} {1} {2} = {3} ", primeroOperando, operacionMatematica, segundoOperando, resultado); 

                Console.WriteLine("Desea continuar? [S/N]: ");
                continuarTexto = Console.ReadLine();
                _ = char.TryParse(continuarTexto, out continuar);
            }
        }
    }
}
