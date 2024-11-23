using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo2
{
    internal class Circular
    {
        private Nodocircular Primero = new Nodocircular();
        private Nodocircular Ultimo = new Nodocircular();


        public Circular()
        {
            Primero = null;
            Ultimo = null;
        }

        public void InsertarNodo(int dato)
        {
            Nodocircular nuevo = new Nodocircular();
            nuevo.Dato = dato;
            if (Primero == null)
            {
                Primero = nuevo;
                Primero.Siguiente = Primero;
                Ultimo = Primero;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Siguiente = Primero;
                Ultimo = nuevo;
            }
        }
        public void MostarLs(TextBox list)
        {
            Nodocircular actual=new Nodocircular();
            actual = Primero;
            if (Primero != null) {
                do
                {
                    list.Text += actual.Dato + "->";
                    actual=actual.Siguiente;
                }while(actual!=Primero);
            }
            else
            {
                MessageBox.Show("Lista vacia");
            }
        }

        public void BuscarNodo(int dato)
        {
            Nodocircular actual = new Nodocircular();
            actual = Primero;

            bool encontrado = false;
            int buscado = dato;
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
                } while (actual != Primero);
                if (encontrado == false) 
                    MessageBox.Show(buscado + " No esta en la lista");
            }
            else
            {
                MessageBox.Show(buscado + "Lista vacia");
            }
        }

        public void eliminarNodo(int dato)
        {
            Nodocircular actual= new Nodocircular();
            actual = Primero;
            Nodocircular anterior =new Nodocircular();
            bool encontrado = false;
            int buscado = dato;
            if (actual != null)
            {
                do
                {
                    if (actual.Dato == buscado)
                    {
                        MessageBox.Show("Nodo " + buscado + "Encontrado");
                        if (actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                            Ultimo.Siguiente = Primero;
                        }
                        else if (actual == Ultimo) {
                            anterior.Siguiente= Primero;
                            Ultimo = anterior;
                        }
                        else
                        {
                            anterior.Siguiente = actual.Siguiente;
                        }
                        MessageBox.Show("Nodo eliminado");
                        encontrado = true;
                    }
                    anterior=actual;
                    actual = actual.Siguiente;
                } while (actual!=Primero);
                if (encontrado == false)
                    MessageBox.Show("No esta en la lista");

            }
            else
            {
                MessageBox.Show("Lista vacia");
            }
        }

    }   
}
