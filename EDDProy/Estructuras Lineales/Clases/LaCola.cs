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
    public partial class LaCola : Form
    {
            Cola cola = new Cola();
        public LaCola()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Caja.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un valor valido");
            }
            else
            {
                Nodo nuevoNodo=new Nodo();
                nuevoNodo.Nombre = Caja.Text;
                cola.Encolar(nuevoNodo);
                MostraCola();
            }
        }

        private void Desencola_Click(object sender, EventArgs e)
        {
            if (cola.Vacia())
            {
                MessageBox.Show("La cola esta vacia");
            }
            else
            {
                cola.desencolar();
                MostraCola();
            }
        }
        private void MostraCola()
        {
            Datos.Items.Clear();
            MostrarNodo(cola.Inicio);
        }

        private void MostrarNodo(Nodo newNodo)
        {
          
            if (newNodo != null)
            {
                Datos.Items.Add(newNodo.Nombre);
                if (newNodo.siguiente != null)
                {
                    MostrarNodo(newNodo.siguiente);
                }
            }  
        }

        private void LaCola_Load(object sender, EventArgs e)
        {

        }
       
        private void Busca_Click(object sender, EventArgs e)
        {
            cola.BuscarNodo(Caja.Text);
        }
    }
}
