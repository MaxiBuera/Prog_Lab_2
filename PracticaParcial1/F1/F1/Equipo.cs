using System;

namespace F1
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;

        public string Nombre
        {
            get { return nombre; }
        }
        public int PE
        {
            get { return PE; }
            set { PE = value; }
        }
        public int PG
        {
            get { return PG; }
            set { PG = value; }
        }
        public int PJ
        {
            get { return PJ; }
            set { PJ = value; }
        }
        public int PP
        {
            get { return PP; }
            set { PP = value; }
        }
        public int Puntuacion
        {
            get { return PP; }
            set { PP = value; }
        }
        public string Tipo
        {
            get { return Tipo; }
        }
    }
}
