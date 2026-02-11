using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class APIMercadoPagoProxy : Ipago
    {
        public bool devolver(double monto)
        {
            // Invoco a la API de MErcado PAGO y Devuelvo la guita
            File.WriteAllText("c:/temp/apiPago.txt", "No hacemos nada! es PROXY, devolver: " + monto.ToString());
            return true;
        }

        public bool pagar(double monto)
        {
            // invoco a la api REAL!! 
            File.WriteAllText("c:/temp/apiPago.txt", "No hacemos nada! es PROXY, pagar: " + monto.ToString());
            return true;

        }
        public double consultar()
        {
            File.WriteAllText("c:/temp/apiPago.txt", "No hacemos nada! es PROXY, consultar: ");
            return 32323;
        }
        public bool AgregarMp(string Nombre)
        {
            // Simula agregar un método específico del proxy
            File.WriteAllText("c:/temp/apiPago.txt", "Agregando MP: " + Nombre);
            return true;
        }
    }
}
