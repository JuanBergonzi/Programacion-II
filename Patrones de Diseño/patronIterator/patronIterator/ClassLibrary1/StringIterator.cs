using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StringIterator : IIterator<char>
    {
        private string iteraObj;
        private int indice; 


        public void setiteraObj (string str)
        {
            iteraObj = str;
            indice = 0;
        }

      
        public void GoFirst()
        {
            indice = 0;
        }

        public void GoLast()
        {
            if (iteraObj.Length != 0)
            {
                indice = iteraObj.Length - 1;
            }
        }

        public bool HasNext()
        {
            return indice < iteraObj.Length;

        }

        public bool HasPrior()
        {
            return indice > 0 && iteraObj.Length > 0;
        }

        public char Next()
        {
            // devuelvo donde estoy parado
            if (HasNext()) { 
                 char aDevolver = iteraObj[indice];
                indice++;
                return aDevolver;
            } else { throw new IndexOutOfRangeException(); }
        }

        public char Prior()
        {
            if (HasPrior())
            {
                indice--;
                char elreturn = Next();
                indice--;
                return elreturn;
            } else { throw new IndexOutOfRangeException(); }

        }

       
    }
}
