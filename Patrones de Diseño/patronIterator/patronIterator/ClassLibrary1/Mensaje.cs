using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mensaje
    {
        public string usuario { get; set; }
        public string mensaje { get; set; }
        public Mensaje(string usuario, string mensaje)
        {
            this.usuario = usuario;
            this.mensaje = mensaje;
        }
      
        public static List<Mensaje> BaseMensajes { get; set; }
        public static List<Mensaje> getMensajes()
        {
            BaseMensajes.Add(new Mensaje("Matias", "Acordate de pagar la patente"));
            BaseMensajes.Add(new Mensaje("Pedro", "Ir a vistiar a los parientes"));
            BaseMensajes.Add(new Mensaje("Ernesto", "apagá el agua"));
            BaseMensajes.Add(new Mensaje("Pedro", "pedite licencia "));
            BaseMensajes.Add(new Mensaje("Matias", "anda al cajero"));
            BaseMensajes.Add(new Mensaje("Matias", "busca el pan de la panaderia"));

            return BaseMensajes;
        }
        public class MensajeIterator : IIterator<char>
        {
            private string contenido;
            private int indice;

            public MensajeIterator(string usuario)
            {
                // Une todos los mensajes del usuario en un solo string
                contenido = string.Concat(
                    Mensaje.getMensajes()
                        .Where(m => m.usuario.Equals(usuario, StringComparison.OrdinalIgnoreCase))
                        .Select(m => m.mensaje + " ") // separamos con espacio entre mensajes
                );

                indice = 0;
            }
            public bool HasNext()
            {
                return indice < contenido.Length;
            }

            public bool HasPrior()
            {
                return indice > 0 && contenido.Length > 0; ;
            }

            public char Next()
            {
                if (HasNext())
                    return contenido[indice++];
                else
                    throw new IndexOutOfRangeException("No hay más caracteres.");
            }

            public char Prior()
            {
                if (HasPrior())
                    return contenido[--indice];
                else
                    throw new IndexOutOfRangeException("No hay caracteres anteriores.");
            }

            public void GoFirst()
            {
                indice = 0;
            }

            public void GoLast()
            {
                if (contenido.Length > 0)
                    indice = contenido.Length - 1;
            }
            public string GetContenido()
            {
                return contenido;
            }

            public int Posicion()
            {
                return indice;
            }
        }
    }
}
