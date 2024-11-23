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
    public partial class ListaCirc : Form
    {
        public ListaCirc()
        {
            InitializeComponent();
        }

        private void ListaCirc_Load(object sender, EventArgs e)
        {

        }
        Circular lista;
        private void button1_Click(object sender, EventArgs e)
        {
           lista = new Circular();
            MessageBox.Show("Lista creada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista.InsertarNodo(int.Parse(cajita.Text));
            cajita.Text = "";cajita.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btverlista.Text = "";
            lista.MostarLs(btverlista);

        }

        private void button5_Click(object sender, EventArgs e)
        {
              
            lista.eliminarNodo(int.Parse(cajita.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lista.BuscarNodo(int.Parse(cajita.Text));
        }
    }
}
