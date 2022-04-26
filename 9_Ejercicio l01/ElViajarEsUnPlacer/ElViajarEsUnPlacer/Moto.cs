using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElViajarEsUnPlacer
{
    public class Moto : VehiculoTerrestre
    {
        public short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas,Colores color,short cilindrada):base(cantidadRuedas, cantidadPuertas, color)
        {

            this.cilindrada = cilindrada;
        }

        public string MostrarVehiculo()
        {

            return $"Vehiculo: {this.GetType().Name} Cantidad Ruedas: {this.cantidadRuedas} Cantidad Puertas: {this.cantidadPuertas} Cilindrada: {this.cilindrada} Color: {this.color}";
        }
    }
}
