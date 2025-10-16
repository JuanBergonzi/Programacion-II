using Celulares.Celulares;
using System.Collections.Generic;

namespace CLogica.Implementation.Contracts
{
    public interface ICelularService
    {
        List<Celular> GetCelulares();
        Celular? GetCelularesId(int id);
        void AgregarCelulares(Celular celular);
        void ActualizarCelulares(Celular celular);
        void DeleteCelulares(int id);
    }
}