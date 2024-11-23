using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo2
{
    class Cola
    {
        Nodo inicio;
        public void Encolar(Nodo newNodo)
        {
            if (inicio == null)
            {
                inicio = newNodo;
            }
            else
            {
                Nodo aux = BuscarUlt(inicio);
                aux.siguiente = newNodo;
            }
        }

        private Nodo BuscarUlt(Nodo newNodo) {
            if (newNodo.siguiente == null)
            {
                return newNodo;
            }
            else
            {
                return BuscarUlt(newNodo.siguiente);
            }
        }

        public void desencolar()
        {
            inicio = inicio.siguiente;
        }

        public Nodo Inicio
        {
            get { return inicio; }
        }

        public bool Vacia()
        {
            return (inicio == null);
        }

        public void BuscarNodo(String dat)
        {
            Nodo actual = new Nodo();
            actual = inicio;

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
                } while (actual != inicio && actual != null);
                if (encontrado == false)
                    MessageBox.Show(buscado + " No esta en la lista");
            }
            else
            {
                MessageBox.Show(buscado + "Lista vacia");
            }
        }

    }
}
