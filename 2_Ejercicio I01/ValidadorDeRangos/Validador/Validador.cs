using System;

namespace Validador
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor >= min && valor <= max)
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
