using Celulares;
using CDatos.Context;
using System.Collections.Generic;
using System.Linq;
using Celulares.Celulares;

namespace CDatos.Repositorios
{
    public class CelularRepositorio : ICelularRepositorio
    {
        private readonly DataContext _context;

        public CelularRepositorio(DataContext context)
        {
            _context = context;
        }

        public List<Celular> GetAll()
        {
            _context.Celulares.ToList();
            return _context.Celulares.ToList();
        }

        public Celular? GetById(int id)
        { 
            _context.Celulares.Find(id);
            return _context.Celulares.Find(id);
        }


        public void Add(Celular celular)
        {
            _context.Celulares.Add(celular);
            _context.SaveChanges();
        }

        public void Update(Celular celular)
        {
            var existente = _context.Celulares.Find(celular.Id);
            if (existente != null)
            {
                existente.Marca = celular.Marca;
                existente.Modelo = celular.Modelo;
                existente.Precio = celular.Precio;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var existente = _context.Celulares.Find(id);
            if (existente != null)
            {
                _context.Celulares.Remove(existente);
                _context.SaveChanges();
            }
        }
    }
}