using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2
{
    internal class NodoCircDo
    {
        public int Valor { get; set; }
        public NodoCircDo Siguiente { get; set; }

        public NodoCircDo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }
}
