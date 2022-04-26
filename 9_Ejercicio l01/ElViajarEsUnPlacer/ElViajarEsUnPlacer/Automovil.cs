using System;

namespace ElViajarEsUnPlacer
{
    public class Automovil : VehiculoTerrestre
    {

        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public string MostrarVehiculo()
        {

            return $"Vehiculo: {this.GetType().Name} Cantidad Ruedas: {this.cantidadRuedas} Cantidad Puertas: {this.cantidadPuertas} Cantidad Marchas: {this.cantidadMarchas} Color: {this.color}";
        }
    }
}
