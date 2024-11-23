using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo2
{
    public partial class LaPila : Form
    {
        
        Pila pila = new Pila();
        public LaPila()
        {
            InitializeComponent();
        }   

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            Nodo NewNodo = new Nodo();
            NewNodo.Nombre = Texto.Text;
            pila.Apilar(NewNodo);

            MostraPila();
        }
        void MostraPila()
        {
            Datos.Items.Clear();
            if (pila.Tope() != null)
            {

                MostrarNodo(pila.Tope());
            }
        }
        void MostrarNodo(Nodo newNodo)
        {
            Datos.Items.Add(newNodo.Nombre);

            if (newNodo.siguiente != null)
            {
                MostrarNodo(newNodo.siguiente);
            }
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            pila.Eliminar();

            MostraPila();
        }
        

        private void Buscar_Click(object sender, EventArgs e)
        {
          
            pila.BuscarNodo(Texto.Text);
        }
       
    }
}
