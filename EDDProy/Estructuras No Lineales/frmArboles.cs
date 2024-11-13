using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (miArbol.busqueda(int.Parse(txtDato.Text), miArbol.RegresaRaiz())) 
            {
                MessageBox.Show("El dato ya está en el árbol.");
            }

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";

 
        }

        private void btnPodar_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtDato.Text, out valor)) 
            {
                
                if (MessageBox.Show("¿Deseas podar el subárbol izquierdo?", "Confirmar poda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    miArbol.PodarSubarbolIzquierdo(ref miRaiz);
                    MessageBox.Show("Subárbol izquierdo podado.");
                }
                else
                {
                    miArbol.PodarSubarbolDerecho(ref miRaiz);
                    MessageBox.Show("Subárbol derecho podado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor válido.");
            }

           
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();
            HashSet<int> numerosGenerados = new HashSet<int>();
            for (int nNodos =1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato;
                do
                {
                    Dato = rnd.Next(1, 100);
                } while (numerosGenerados.Contains(Dato)); // Repite hasta encontrar un número único

                // Agrega el número generado al HashSet
                numerosGenerados.Add(Dato);

                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtDato.Text, out valor)) 
            {
                miArbol.BucarNodo(valor); 
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor;


            if (int.TryParse(txtDato.Text, out valor)) // Usamos el valor ingresado en el cuadro de texto
            {
                // Llamamos a la función de eliminar nodo por sucesor
                miArbol.EliminarNodoPorSucesor(valor, ref miRaiz);
                MessageBox.Show($"Nodo con valor {valor} eliminado usando el sucesor.");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor válido.");
            }

            txtArbol.Text = "";
            miArbol.strArbol = "";

            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtDato.Text, out valor)) 
            {
               
                miArbol.EliminarNodoPorPredecesor(valor, ref miRaiz);
                MessageBox.Show($"Nodo con valor {valor} eliminado usando el predecesor.");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor válido.");
            }

            txtArbol.Text = "";
            miArbol.strArbol = "";

            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void btnPodar_Click_1(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtDato.Text, out valor)) 
            {
               
                if (MessageBox.Show("¿Deseas podar el subárbol izquierdo?", "Confirmar poda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    miArbol.PodarSubarbolIzquierdo(ref miRaiz);
                    MessageBox.Show("Subárbol izquierdo podado.");
                }
                else
                {
                    miArbol.PodarSubarbolDerecho(ref miRaiz);
                    MessageBox.Show("Subárbol derecho podado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor válido.");
            }

           
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblRecorridoPorNiveles.Text = "";

            
            NodoBinario raiz = miArbol.RegresaRaiz();

            miArbol.strRecorrido = "";

            miArbol.RecorridoPorNiveles(raiz);

            lblRecorridoPorNiveles.Text = miArbol.strRecorrido;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NodoBinario raiz = miArbol.RegresaRaiz();

            if (raiz == null)
            {
                lblAltura.Text = "El árbol está vacío.";
                return;
            }

            int altura = miArbol.ObtenerAltura(raiz);

            lblAltura.Text = "La altura del árbol es: " + altura.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NodoBinario raiz = miArbol.RegresaRaiz();

            if (raiz == null)
            {
                lblCantidadHojas.Text = "El árbol está vacío.";
                return;
            }

            int cantidadHojas = miArbol.ObtenerCantidadDeHojas(raiz);

            lblCantidadHojas.Text = "La cantidad de hojas es: " + cantidadHojas.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NodoBinario raiz = miArbol.RegresaRaiz();

            if (raiz == null)
            {
                lblCantidadNodos.Text = "El árbol está vacío.";
                return;
            }

            int cantidadNodos = miArbol.ObtenerCantidadDeNodos(raiz);

            lblCantidadNodos.Text = "La cantidad de nodos es: " + cantidadNodos.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NodoBinario raiz = miArbol.RegresaRaiz();

            if (raiz == null)
            {
                lblEsCompleto.Text = "El árbol está vacío.";
                return;
            }

            // Contamos el total de nodos en el árbol
            int numeroNodos = miArbol.ContarNodos(raiz);

            // Verificamos si el árbol es completo
            if (miArbol.EsArbolBinarioCompleto(raiz, 0, numeroNodos))
            {
                lblEsCompleto.Text = "Esta completo.";
            }
            else
            {
                lblEsCompleto.Text = "No es completo.";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NodoBinario raiz = miArbol.RegresaRaiz();

            if (raiz == null)
            {
                lblEsLleno.Text = "El árbol está vacío.";
                return;
            }

            if (miArbol.EsArbolBinarioLleno(raiz))
            {
                lblEsLleno.Text = "El árbol es binario lleno.";
            }
            else
            {
                lblEsLleno.Text = "El árbol no es binario lleno.";
            }
        }

        private void txtArbol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
