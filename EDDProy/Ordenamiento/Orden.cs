using EDDemo.Ordenamiento.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDDemo.Ordenamiento
{
    public partial class Orden : Form
    {
        private Shellsort shellsort;

        public Orden()
        {
            InitializeComponent();
            shellsort = new Shellsort(); 
        }

        void button1_Click(object sender, EventArgs e)
        {
            
            int cantidad = (int)numericUpDown1.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.");
                return;
            }

            shellsort.GenerarListaAleatoria(cantidad);
            MostrarListaDes(shellsort.GetLista());

        }

        void button2_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            shellsort.OrdenarLista();
            MostrarLista(shellsort.GetLista());

            sw.Stop();
            textBox1.Text = sw.Elapsed.ToString();
        }

        private void MostrarLista(int[] lista)
        {
           txtShellSort.Text = string.Join(", ", lista);
        }
        private void MostrarListaDes(int[] lista)
        {
           txtDesorden.Text = string.Join(", ", lista);
        }

        private void Radix_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            shellsort.OrdenarListaRadix();
            MostrarLista(shellsort.GetLista());

            sw.Stop();
            textBox1.Text = sw.Elapsed.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBusqueda.Text, out int numeroBuscado))
            {
                int resultado = shellsort.BuscarBinario(numeroBuscado);

                if (resultado != -1)
                {
                    MessageBox.Show($"Número encontrado en el lugar: {resultado+1} de la lista");
                }
                else
                {
                    MessageBox.Show("Número no encontrado en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBusqueda.Text, out int numeroBuscado))
            {
                bool encontrado = shellsort.BuscarPorHash(numeroBuscado);

                if (encontrado)
                {
                    MessageBox.Show("Número encontrado en la tabla.");
                }
                else
                {
                    MessageBox.Show("Número no encontrado en la tabla.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número.");
            }
        }
    }
}
