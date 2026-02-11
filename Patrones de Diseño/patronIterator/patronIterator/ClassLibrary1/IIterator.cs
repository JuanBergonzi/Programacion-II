using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IIterator<LaClase>
    {
        bool HasNext();
        bool HasPrior();
        LaClase Next();
        LaClase Prior();
        void GoFirst();
        void GoLast();
        
    }
}
