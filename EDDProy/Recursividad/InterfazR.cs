using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo;


namespace EV2
{
    public partial class InterfazR : Form
    {
        public InterfazR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factorial bt1 = new Factorial();
            bt1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculoExp bt2 = new CalculoExp();
            bt2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SumElem bt3 = new SumElem();
            bt3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fibonacci bt4 = new Fibonacci();
            bt4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BusqBi bt5 = new BusqBi();
            bt5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TorreHanoi bt6 = new TorreHanoi();
            bt6.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
