using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo2;

namespace Trabajo2
{
    internal class ListaCircular
    {
        private NodoCircDo cabeza;

        public ListaCircular()
        {
            cabeza = null;
        }

        public void Agregar(int valor)
        {
            NodoCircDo nuevo = new NodoCircDo(valor);
            if (cabeza == null)
            {
                cabeza = nuevo;
                cabeza.Siguiente = cabeza; 
            }
            else
            {
                NodoCircDo actual = cabeza;
                while (actual.Siguiente != cabeza)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
                nuevo.Siguiente = cabeza; 
            }
        }

        public string Buscar(int valor)
        {
            if (cabeza == null) return "Lista vacía.";
            NodoCircDo actual = cabeza;
            do
            {
                if (actual.Valor == valor)
                    return $"Nodo {valor} encontrado.";
                actual = actual.Siguiente;
            } while (actual != cabeza);
            return $"Nodo {valor} no encontrado.";
        }

        public string Eliminar(int valor)
        {
            if (cabeza == null) return "Lista vacía.";

            NodoCircDo actual = cabeza;
            NodoCircDo anterior = null;

            do
            {
                if (actual.Valor == valor)
                {
                    if (anterior == null) 
                    {
                        if (cabeza.Siguiente == cabeza) 
                        {
                            cabeza = null;
                        }
                        else
                        {
                            NodoCircDo ultimo = cabeza;
                            while (ultimo.Siguiente != cabeza)
                            {
                                ultimo = ultimo.Siguiente;
                            }
                            cabeza = cabeza.Siguiente;
                            ultimo.Siguiente = cabeza; 
                        }
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente; 
                    }
                    return $"Nodo {valor} eliminado.";
                }
                anterior = actual;
                actual = actual.Siguiente;
            } while (actual != cabeza);

            return $"Nodo {valor} no encontrado.";
        }

        public string Mostrar()
        {
            if (cabeza == null) return "Lista vacía.";
            string resultado = "";
            NodoCircDo actual = cabeza;
            do
            {
                resultado += actual.Valor + " -> ";
                actual = actual.Siguiente;
            } while (actual != cabeza);
            return resultado;
        }
       
    }
}