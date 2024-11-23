using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;
using EV2;
using Trabajo2;


namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 EstrucL = new Form1();
            EstrucL.MdiParent = this;
            EstrucL.Show();
        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void recursividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazR interfaz = new InterfazR();
            interfaz.MdiParent = this;
            interfaz.Show();
        }
    }
}
