using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo2
{
    internal class Lista
    {
        private NodoSimp Top = new NodoSimp();
        private NodoSimp aux = new NodoSimp();


        public Lista()
        {
            Top = null;
            aux = null;
        }

        public void InsertarNodo(int valor)
        {
            NodoSimp nuevo = new NodoSimp();
            nuevo.Nombre = valor;

            if (Top == null)
            {
                Top = nuevo;
                nuevo.Atras = null;
            }
            else
            {
                NodoSimp actual = Top;
                while (actual.Atras != null)
                {
                    actual = actual.Atras;
                }
                actual.Atras = nuevo;
                nuevo.Atras = null;
            }
        }
        public void MostarLs(TextBox list)
        {
            NodoSimp actual = new NodoSimp();
            actual = Top;
            if (Top != null)
            {
                list.Text = "";
                while (actual != null)
                {
                    list.Text += actual.Nombre + " -> ";
                    actual = actual.Atras;
                }
                list.Text += "null";
            }
            else
            {
                MessageBox.Show("Lista vacia");
            }
        }

        public void BuscarNodo(int dato)
        {
            NodoSimp actual = new NodoSimp();
            actual = Top;

            bool encontrado = false;
            while (actual != null)
            {
                if (actual.Nombre == dato)
                {
                    MessageBox.Show("Nodo " + dato + " encontrado");
                    encontrado = true;
                    break;
                }
                actual = actual.Atras;
            }

            if (!encontrado)
                MessageBox.Show(dato + " no está en la lista");
        }

        public void eliminarNodo(int dato)
        {
            if (Top == null) // Si la lista está vacía
            {
                MessageBox.Show("Lista vacía");
                return;
            }


            NodoSimp actual = new NodoSimp();
            actual = Top;
            NodoSimp anterior = new NodoSimp();
            anterior = null;
            bool encontrado = false;
            while (actual != null)
            {
                if (actual.Nombre == dato)
                {
                    encontrado = true;
                    if (anterior == null) // Si el nodo a eliminar es el primero
                    {
                        Top = actual.Atras; // Cambia Top al siguiente nodo
                    }
                    else
                    {
                        anterior.Atras = actual.Atras; // Elimina el nodo intermedio
                    }
                    MessageBox.Show("Nodo " + dato + " eliminado");
                    break;
                }
                anterior = actual;
                actual = actual.Atras;
            }

            if (!encontrado)
                MessageBox.Show("No está en la lista");
        }
    }

}

