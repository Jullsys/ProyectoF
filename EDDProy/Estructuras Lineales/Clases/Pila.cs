using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo2
{
    internal class Pila
    {
        Nodo tope;
        public Nodo Tope()
        {
            return tope;
        }

        public void Apilar(Nodo newNodo)
        {
            if (tope == null) {
                tope = newNodo;
            }
            else
            {
                Nodo aux = tope;
                tope = newNodo;
                tope.siguiente = aux;
            }
        }
        public void BuscarNodo(String dat)
        {
            Nodo actual = new Nodo();
            actual = tope;

            bool encontrado = false;
            String buscado = dat;
            if (actual != null)
            {
                do
                {
                    if (actual.Nombre == buscado)
                    {
                        MessageBox.Show("Nodo " + buscado + " Encontrado");
                        encontrado = true;
                    }
                    actual = actual.siguiente;
                } while (actual != tope && actual != null);
                if (encontrado == false)
                    MessageBox.Show(buscado + " No esta en la lista");
            }
            else
            {
                MessageBox.Show(buscado + "Lista vacia");
            }
        }
        public void Eliminar()
        {
            if (tope!=null) {
                tope = tope.siguiente;

            }
        }
    }
}
