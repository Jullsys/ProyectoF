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
    public partial class ListCircDo : Form
    {
        

        public ListCircDo()
        {
            InitializeComponent();
            
        }
        ListaCircular lista;
        private void ListCircDo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista = new ListaCircular();
            MessageBox.Show("Lista creada");
        }
     
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                lista.Agregar(valor);
                txtResultado.Text = lista.Mostrar();
                txtValor.Clear();
                txtValor.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                MessageBox.Show(lista.Buscar(valor));
                txtValor.Clear();
                txtValor.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                MessageBox.Show(lista.Eliminar(valor));
                txtResultado.Text = lista.Mostrar();
                txtValor.Clear();
                txtValor.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
    }
}
