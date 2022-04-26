using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCalculadoraDeFormas
{
    public class Circulo : Figura
    {

        private float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando circulo...";
        }
        public override double CalcularSuperficie()
        {
            return Math.PI + Math.Pow(this.radio, 2);
        }
        public override double CalcularPerimetro()
        {
            return Math.PI * this.radio * 2;
        }

    }
}
