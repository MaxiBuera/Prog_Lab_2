using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrescribiendoEsasAdvertencias
{
    internal class Sobreescrito
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!.";
        } 
        public override bool Equals(object obj)
        {
            if (this.GetType() == typeof(Sobreescrito))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
