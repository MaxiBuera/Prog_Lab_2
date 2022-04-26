using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCalculadoraDeFormas
{
    public class Rectangulo : Figura
    {
        private float ladoBase;
        private float ladoAltura;

        public Rectangulo(float ladoBase, float ladoAltura)
        {
            this.ladoBase = ladoBase;
            this.ladoAltura = ladoAltura;
        }


        public override string Dibujar()
        {
            return "Dibujando rectangulo...";
        }

        public override double CalcularSuperficie()
        {
            return this.ladoBase * this.ladoAltura;
        }
        public override double CalcularPerimetro()
        {
            return (this.ladoBase + this.ladoAltura) * 2;
        }
    }
}
