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
    public partial class BusqBi : Form
    {
        public BusqBi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//creamos el arreglo
            int numero = Convert.ToInt32(textBox1.Text);//convertimos el tipo String en entero
            textBox2.Text = Busqueda(array,numero,0).ToString();//Mostramos la ubicacion en la caja de texto

            int Busqueda(int[]arreglo,int x, int indice)//creamos la funcion con sus parametros.
            {
                if (indice < arreglo.Length)//ponemos la condicion que pregunta si indice es menor a la longitud del arreglo
                {
                    if (arreglo[indice] == x)//si encuentra que indice es igual a X, nos regresa indice
                    {
                        return indice;
                    }
                    else
                    {
                        return Busqueda(arreglo,x, indice+1);//sino lo encuentra que se recorra el arreglo
                    }
                    
                }
                return -1;//si recorre todo el arreglo y no lo encuentra nos arroja un -1
            }
            sw.Stop();
            textBox3.Text = sw.Elapsed.ToString();

        }

    }
}
