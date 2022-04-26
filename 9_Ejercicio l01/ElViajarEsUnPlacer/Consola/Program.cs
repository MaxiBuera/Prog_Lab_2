using System;
using System.Collections.Generic;
using ElViajarEsUnPlacer;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camion1 = new Camion(4, 2, Colores.Gris, 6, 50);
            Camion camion2 = new Camion(4, 2, Colores.Azul, 5, 60);

            Moto moto1 = new Moto(2, 0, Colores.Blanco, 123);
            Moto moto2 = new Moto(2, 0, Colores.Azul, 125);

            Automovil automovil1 = new Automovil(4, 2, Colores.Rojo, 4, 6);

            /*----------------------------------------------------*/

            List<VehiculoTerrestre> lista = new List<VehiculoTerrestre>();
            lista.Add(camion1);
            lista.Add(camion2);
            lista.Add(moto1);
            lista.Add(moto2);
            lista.Add(automovil1);

            foreach (VehiculoTerrestre vehiculo in lista)
            {
                if (vehiculo is Camion)
                {
                    Console.WriteLine(((Camion)vehiculo).MostrarVehiculo());
                }
                else if (vehiculo is Moto)
                {
                    Console.WriteLine(((Moto)vehiculo).MostrarVehiculo());
                }
                else
                {
                    Console.WriteLine(((Automovil)vehiculo).MostrarVehiculo());

                }
            }
        }
    }
}
