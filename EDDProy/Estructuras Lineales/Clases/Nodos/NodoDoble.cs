using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2
{
    internal class NodoDoble
    {
        private int dato;
        private NodoDoble siguiente;
        private NodoDoble atras;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoDoble Siguiente
        {
            get { return siguiente; }
            set{ siguiente=value; }
        }
        public NodoDoble Atras
        {
            get { return atras; }
            set { atras = value; }
        }
    }
    
}
