using Celulares;
using Celulares.Celulares;
using System.Collections.Generic;

namespace CDatos.Repositorios
{
    public interface ICelularRepositorio
    {
        List<Celular> GetCelulares();
        Celular? GetCelularesId(int id);
        void AgregarCelulares(Celular celular);
        void ActualizarCelulares(Celular celular);
        void DeleteCelulares(int id);
    }
}