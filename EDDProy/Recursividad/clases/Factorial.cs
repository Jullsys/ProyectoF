using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV2
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }
        private void calcular_Click_1(object sender, EventArgs e)//Definiremos dentro todo lo que se hara al presionar el boton
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int Factorial(int n)//creamos una funcion
            {
                if (n <= 1)
                {
                    return 1; // Caso base y la condicion de corte
                }
                else
                {
                    return n * Factorial(n - 1); // Llamada recursiva
                }
            }
            sw.Stop();
            
            int numero = Convert.ToInt32(textBox1.Text);//convertimos el dato String que nos da el usuario a entero y lo guardamos en una variable
        textBox2.Text = Factorial(numero).ToString();//Definimos que nuestro resultado lo vuelva a convertir a String para que lo muestre en el 2do Label
        textBox3.Text=sw.Elapsed.ToString();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
