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
    public partial class TorreHanoi : Form
    {
        public TorreHanoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            listBox1.Items.Clear();
            int numDiscos = int.Parse(textBox1.Text);
           
            ResolverTorreDeHanoi(numDiscos, 'A', 'C', 'B');

            void ResolverTorreDeHanoi(int numDiscoss, char origen, char destino, char auxiliar)
            {
                // Caso base: Si solo hay un disco, simplemente moverlo de origen a destino
                if (numDiscoss == 1)
                {
                   listBox1.Items.Add($"Mover disco 1 de {origen} a {destino}");
                }
                else
                {
                    // Mover numDiscos-1 discos de origen a auxiliar, usando destino como auxiliar
                    ResolverTorreDeHanoi(numDiscoss - 1, origen, auxiliar, destino);

                    // Mover el disco más grande (el que queda) de origen a destino
                    listBox1.Items.Add($"Mover disco {numDiscoss} de {origen} a {destino}");

                    // Mover los numDiscos-1 discos de auxiliar a destino, usando origen como auxiliar
                    ResolverTorreDeHanoi(numDiscoss - 1, auxiliar, destino, origen);
                }
            }

            sw.Stop();
            textBox2.Text = sw.Elapsed.ToString();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
