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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //creamos el metodo con un parametro.
            int Fibonacci(int num)
            {//condicion base.
                int resultado=0;
                if (num <= 1)
                {
                    return num;
                }
                else
                { //Empieza la recursividad y donde se suman los valores
                    return resultado= Fibonacci(num - 1) + Fibonacci(num - 2);
                }
            }
            sw.Stop();

            int numero = Convert.ToInt32(textBox1.Text);//convertimos en entero el dato que el usuario ingresa
            textBox2.Text = Fibonacci(numero).ToString();//Mostramos el valor en la caja de texto.
            textBox3.Text = sw.Elapsed.ToString();
        }
    }
}

