using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ConfigSingleton
    {
        public static ConfigSingleton instancia;

        public static string ambiente = "TEST"; // PRO o TEST

        public static ConfigSingleton DameInstancia()
        {
            if (instancia == null)
            {
                instancia = new ConfigSingleton();
            }
            return instancia;
        }

        public bool isTesting()
        {
            // Evalua si está en ambiten de TEST si o no 
            return (ambiente != "PRO");
         
        }
        public void procesarPago (double monto)
        {
            Ipago laAPI; 
            if (isTesting())
            {
                
                laAPI = new APIMercadoPagoProxy();
            }
            else
            {
                laAPI = new APIMercadoPago();
            }
            laAPI.pagar(monto);
        }
        public void procesarDevol(double monto)
        {
            Ipago laAPI;
            if (isTesting())
            {

                laAPI = new APIMercadoPagoProxy();
            }
            else
            {
                laAPI = new APIMercadoPago();
            }
            laAPI.devolver(monto);
        }
        public void procesarConsulta(double monto)
        {
            Ipago laAPI;
            if (isTesting())
            {
                laAPI = new APIMercadoPagoProxy();
            }
            else
            {
                laAPI = new APIMercadoPago();
            }
            laAPI.consultar();
        }
        public void AgregarMp(string Nombre)
        {
            Ipago laAPI;
            if (isTesting())
            {
                laAPI = new APIMercadoPagoProxy();
            }
            else
            {
                laAPI = new APIMercadoPago();
            }
            laAPI.AgregarMp(Nombre);
        }
    }
}
