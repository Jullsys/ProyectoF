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
    public partial class ListaDoble : Form
    {
        public ListaDoble()
        {
            InitializeComponent();
        }
        ListaDo obLista;
        private void button1_Click(object sender, EventArgs e)
        {
            obLista=new ListaDo();
            MessageBox.Show("Lista creada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obLista.innsertarNodo(int.Parse(Dentro.Text));
            Dentro.Text = "";Dentro.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fuera.Text = "";
            if (button3.Text == "Ver Lista I-D") {
                obLista.desplegarListaID(Fuera);
                button3.Text = "Ver Lista D-I";
            }
            else
            {
                obLista.desplegarListaDI(Fuera);
                button3.Text = "Ver Lista I-D";
            }
        }

        private void ListaDoble_Load(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            

           
            int.TryParse(Dentro.Text, out int valor);

              NodoDoble nodoAEliminar = obLista.BuscarNodo(valor);
            if (nodoAEliminar != null)
            {
                obLista.EliminarNodo(nodoAEliminar);
                MessageBox.Show("Nodo Eliminado.");
            }
            else
            {
                MessageBox.Show("Nodo no encontrado.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            obLista.Buscarnodo(int.Parse(Dentro.Text));
        }
    }
}
