using System;
using System.Text;

namespace Entidad
{
    public class Estudiante
    {
        public string apellido;
        public string legajo;
        public string nombre;
        public int notaPrimerParcial;
        public int notaSegundoParcial;
        public static Random random;

        //constructor de instancia/no estatico
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        //constructor estatico
        public Estudiante()
        {
            Estudiante.random = new Random();
        }

        public void SetNotaPrimerParcial(Estudiante estudiante, int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(Estudiante estudiante, int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private static int CalcularPromedio(int notaPrimerParcial, int notaSegundoParcial)
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public static int CalcularNotaFinal(Estudiante estudiante)
        {
            Random rnd = new Random();
            int random;
            if(estudiante.notaPrimerParcial >= 4 && estudiante.notaSegundoParcial >= 4)
            {
                random = rnd.Next(4, 10);
                return random;
            } 
            else
            {
                random = -1;
                return random;
            }
        }

        public static void Mostrar(Estudiante estudiante)
        {
            StringBuilder datosAlumno = new StringBuilder();
            int promedio = CalcularPromedio(estudiante.notaPrimerParcial, estudiante.notaSegundoParcial);
            int notaFinal = CalcularNotaFinal(estudiante);
            datosAlumno.Append(Environment.NewLine);
            datosAlumno.AppendLine($"Estudiante: {estudiante.nombre} {estudiante.apellido} {estudiante.legajo}");
            datosAlumno.AppendLine($"Notas: 1ro {estudiante.notaPrimerParcial} 2do {estudiante.notaSegundoParcial}");
            datosAlumno.AppendLine($"Promedio: {promedio}");
            if (notaFinal != -1)
            {
                datosAlumno.AppendLine($"Nota final: {notaFinal} ");
            }
            else
            {
                datosAlumno.AppendLine("Nota final: Alumno desaprobado");
            }

            Console.WriteLine(datosAlumno.ToString());
        }
    }
}
