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
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }

        private void _Pila_Click(object sender, EventArgs e)
        {
            LaPila pilita=new LaPila();
            pilita.ShowDialog();
        }

        private void _Cola_Click_1(object sender, EventArgs e)
        {
            LaCola colita=new LaCola();
            colita.ShowDialog();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            ListaSimple listsimp = new ListaSimple();
            listsimp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaDoble listdos = new ListaDoble();
            listdos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaCirc listcirc = new ListaCirc();
            listcirc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListCircDo listcirco = new ListCircDo();
            listcirco.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
