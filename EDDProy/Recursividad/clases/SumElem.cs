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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EV2
{
    public partial class SumElem : Form
    {
        public SumElem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };//creamos y le damos valores al arreglo
            int suma(int[] arr, int n)//creamos la funcion con sus parametros.
            {
                //condicion base
                if (n <= 1)
                {
                    return 1;
                }
                else
                {
                    //Aqui sumamos los valores y recorremos as posiciones para esto.
                    return suma(array, n - 1) + array[n - 1];
                }

            }
            sw.Stop();
            //imprimimos el valor final de la suma
            textBox1.Text = suma(array, 9).ToString();
            textBox2.Text = sw.Elapsed.ToString();
        }

        private void SumElem_Load(object sender, EventArgs e)
        {

        }
    }
}
