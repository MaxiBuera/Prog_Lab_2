using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElViajarEsUnPlacer
{
    public enum Colores
    {
        Rojo, Blanco, Azul, Gris, Negro
    }

    public class Camion : VehiculoTerrestre
    {

        public short cantidadMarchas;
        public int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas,Colores color, short cantidadMarchas, int pesoCarga):base(cantidadRuedas, cantidadPuertas,color)
        {

            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public string MostrarVehiculo()
        {

            return $"Vehiculo: {this.GetType().Name} Cantidad Ruedas: {this.cantidadRuedas} Cantidad Puertas: {this.cantidadPuertas} Peso: {this.pesoCarga}";
        }
    }
}
