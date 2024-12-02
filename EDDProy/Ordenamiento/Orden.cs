﻿using EDDemo.Ordenamiento.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo2;

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
            shellsort.OrdenarLista();
            MostrarLista(shellsort.GetLista());
        }

        private void MostrarLista(int[] lista)
        {
           txtShellSort.Text = string.Join(", ", lista);
        }
        private void MostrarListaDes(int[] lista)
        {
           txtDesorden.Text = string.Join(", ", lista);
        }

    }
}
