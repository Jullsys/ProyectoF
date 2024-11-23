using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2
{
    internal class NodoSimp
    {
        private int dato;
        private NodoSimp atras;

        public int Nombre { get => dato; set => dato = value; }
        
     
        public NodoSimp Atras
        { get => atras; set => atras = value; }
    }
}
