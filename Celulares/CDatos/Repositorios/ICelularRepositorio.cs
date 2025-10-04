using Celulares;
using Celulares.Celulares;
using System.Collections.Generic;

namespace CDatos.Repositorios
{
    public interface ICelularRepositorio
    {
        List<Celular> GetAll();
        Celular? GetById(int id);
        void Add(Celular celular);
        void Update(Celular celular);
        void Delete(int id);
    }
}