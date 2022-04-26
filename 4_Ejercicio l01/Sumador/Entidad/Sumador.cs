using System;

namespace Entidad
{
    public class Sumador
    {
        public int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {

        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return $"{a}{b}";
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }
    }
}
