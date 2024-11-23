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
            void torresHanoi(int n, int o, int d, int aux)//creamo la funcion con los parametros.
            {
                if (n > 0)//Queremos que n sea mayor a 0 para que asi hayan anillos
                {
                    torresHanoi(n - 1, o, aux, d);//especificamos parametros
                   
                    textBox1.Text ="Se mueve el anillo desde torre "+o+ " hasta torre "+d;
                    torresHanoi(n - 1, aux, d, o);
                }
                else//si pone 0 es que no hay anillos
                {
                    textBox1.Text = "No hay anillos" ;
                }
            }
            int numero = Convert.ToInt32(textBox1.Text);
            sw.Stop();
            torresHanoi(numero, 1, 3, 2);//le damos valores a los parametros.
            textBox2.Text = sw.Elapsed.ToString();
        }
    }
}
