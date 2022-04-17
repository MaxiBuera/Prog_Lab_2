using System;

namespace Prestamo
{
    public class Cuenta
    {
        //Atributos de la clase
        public string razonSocial;
        public decimal cantidad;

        //Constructor
        public Cuenta(string razonSocial, decimal cantidad)
        {
            this.razonSocial = razonSocial;
            this.cantidad = cantidad;
        } 

        public string Mostrar()
        {
            return $"Razon social: {this.razonSocial}\nMonto: {this.cantidad}\n";
        }

        public static void Ingresar(Cuenta cuenta, decimal montoAcreditar)
        {
            if (cuenta.cantidad >= 0)
            {
                cuenta.cantidad += montoAcreditar;
            }
        }

        public static void Retirar(Cuenta cuenta, decimal montoDebitar)
        {
            cuenta.cantidad -= montoDebitar;
        }
    }
}
