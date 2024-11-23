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

namespace EV2
{
    public partial class CalculoExp : Form
    {
        public CalculoExp()
        {
            InitializeComponent();
        }

        private void CalculoExp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int resultado(int num, int exp)//creamos la funcion.
            {
                // Caso base
                if (exp <= 0)
                {
                    return 1;
                }
                // Llamada recursiva y donde hacemos la operacion para sacar el resultado.
                return num * resultado(num,exp - 1);
            }

            sw.Stop();
            int numero = Convert.ToInt32(textBox1.Text);//Convertimos los datos del usuario a entero para poder utilizarlo
            int exponente = Convert.ToInt32(textBox2.Text);
            textBox3.Text = resultado(numero,exponente).ToString();//mostramos el resultado
            textBox4.Text = sw.Elapsed.ToString();
        }
    }
}
