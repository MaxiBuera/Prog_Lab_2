using System;

namespace LaCalculadoraDeFormas
{
    public abstract class Figura
    {
        public virtual string Dibujar()
        {
            return "Dibujando forma...";
        }
        public abstract double CalcularSuperficie();

        public abstract double CalcularPerimetro();
    }
}
