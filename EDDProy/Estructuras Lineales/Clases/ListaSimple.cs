using System;
using System.Collections;
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
    public partial class ListaSimple : Form
    {
      
        public ListaSimple()
        {
            InitializeComponent();
        }
        Lista lista;

        private void button1_Click_1(object sender, EventArgs e)
        {
            lista = new Lista();
            MessageBox.Show("Lista creada");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            lista.InsertarNodo(int.Parse(cajita.Text));
            cajita.Text = ""; cajita.Focus();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            btverlista.Text = "";
            lista.MostarLs(btverlista);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            lista.BuscarNodo(int.Parse(cajita.Text));
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            lista.eliminarNodo(int.Parse(cajita.Text));
        }

        private void ListaSimple_Load(object sender, EventArgs e)
        {

        }
    }
    }
