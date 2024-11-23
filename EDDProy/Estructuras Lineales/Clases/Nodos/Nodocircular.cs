using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2
{
    internal class Nodocircular
    {
        private int dato;
        private Nodocircular siguiente;
        public int Dato { get=>dato; set=>dato=value; }
        internal Nodocircular Siguiente { get => siguiente; set => siguiente = value; }
    }
}
