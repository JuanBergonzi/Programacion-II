using Celulares.Celulares;
using System.Collections.Generic;

namespace CLogica.Implementation.Contracts
{
    public interface ICelularService
    {
        List<Celular> GetAll();
        Celular? GetById(int id);
        void Add(Celular celular);
        void Update(Celular celular);
        void Delete(int id);
    }
}