using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clasess;

namespace Clasess
{
    public class TipoDoc
    {
        public static List<TipoDoc> listita_modelo { get; set; } = new List<TipoDoc>();

        private static int ContadorId = 0;
        public int IdTipoDoc { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public List<Cliente> clientes { get; set; }

        public static void CrearTipoDoc (TipoDoc tiposDoc)
        {
            tiposDoc.IdTipoDoc = ContadorId++;
            listita_modelo.Add (tiposDoc);
        }
        public static void EliminarTipoDoc(string cod)
        {
            TipoDoc eliminar = listita_modelo.FirstOrDefault(a => a.Codigo == cod);
            if(eliminar == null)
            {
                 return;
            }
            listita_modelo.Remove (eliminar);
        }
        
        public static List<TipoDoc> mostrarLista (TipoDoc tiposDoc)
        {
            return listita_modelo;
        }
    }
}
