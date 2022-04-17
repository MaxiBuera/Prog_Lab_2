using System;
using Entidad;

namespace ElEjemploUniversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Pedro","Da Silva","12345");
            estudiante1.SetNotaPrimerParcial(estudiante1,7);
            estudiante1.SetNotaSegundoParcial(estudiante1, 4);

            Estudiante estudiante2 = new Estudiante("Viviana", "Da Silva", "515151");
            estudiante2.SetNotaPrimerParcial(estudiante1, 4);
            estudiante2.SetNotaSegundoParcial(estudiante1, 4);

            Estudiante.Mostrar(estudiante1);
            Estudiante.Mostrar(estudiante2);
        }
    }
}
