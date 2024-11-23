using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo2
{
    internal class ListaDo
    {
        private NodoDoble primero=new NodoDoble();
        private NodoDoble ultimo=new NodoDoble();   


        public ListaDo()
        {
            primero = null;ultimo = null;
        }

        public void innsertarNodo(int valor)
        {
            NodoDoble nuevo=new NodoDoble();
            nuevo.Dato=valor;

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                primero.Atras=null;
                ultimo = primero;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Atras = ultimo;
                ultimo= nuevo;
            }
        }
        public void desplegarListaID(TextBox lst)
        {
            NodoDoble actual = new NodoDoble();
            actual = primero;
            while (actual != null)
            {
                lst.Text += actual.Dato + "->";
                actual=actual.Siguiente;
            }
        }

        public void desplegarListaDI(TextBox lst)
        {
            NodoDoble actual = new NodoDoble();
            actual = ultimo;
            while(actual!= null)
            {
                lst.Text += actual.Dato + "->";
                actual = actual.Atras;
            }
        }
       public void EliminarNodo(NodoDoble nodo)
        {
            if (nodo == null) 
            {
                return;
            }
            if (nodo == primero)
            {
                primero = nodo.Siguiente;
                if (primero != null) {
                    primero.Atras = null;
                }
            }
            else
            {
                if (nodo.Atras != null)
                {
                    nodo.Atras.Siguiente = nodo.Siguiente;
                }
                if (nodo.Siguiente != null)
                {
                    nodo.Siguiente.Atras = nodo.Atras;
                }
            }
            nodo = null;
        }
        public NodoDoble BuscarNodo(int valor)
        {
            NodoDoble actual = primero; 
            while (actual != null)
            {
                if (actual.Dato == valor) 
                {
                    return actual;
                }
                actual = actual.Siguiente; 
            }
            return null;
        }
        public void Buscarnodo(int dat)
        {
            NodoDoble actual = new NodoDoble();
            actual = primero;

            bool encontrado = false;
            int buscado = dat;
            if (actual != null)
            {
                do
                {
                    if (actual.Dato == buscado)
                    {
                        MessageBox.Show("Nodo " + buscado + " Encontrado");
                        encontrado = true;
                    }
                    actual = actual.Siguiente;
                } while (actual != primero && actual != null);
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
