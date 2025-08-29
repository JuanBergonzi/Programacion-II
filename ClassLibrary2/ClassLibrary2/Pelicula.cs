using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Pelicula : Observador
    {
        private List<IObserver> observers = new List<IObserver>();
        public List<string> Peliculas { get; private set; } = new List<string>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string pelicula)
        {
            foreach (var observer in observers)
            {
                observer.Update(pelicula);
            }
        }

        public void AgregarPelicula(string titulo)
        {
            Peliculas.Add(titulo);
            Notify(titulo);
        }
    }
}
