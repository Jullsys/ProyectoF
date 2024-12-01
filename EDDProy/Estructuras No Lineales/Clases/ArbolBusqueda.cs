using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {            
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);          
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public  String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
            
            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo )
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
         }
        public void BucarNodo(int valor)
        {
            if (Raiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            NodoBinario miRaiz = RegresaRaiz();
            if (busqueda(valor, miRaiz) == true) // Cambiar '=' por '=='
            {
                MessageBox.Show("Se ha encontrado el dato " + valor);
            }
            else
            {
                MessageBox.Show("No se ha encontrado el dato " + valor);
            }
        }
       public bool busqueda(int valor, NodoBinario nodo) 
        {
            if (nodo == null) { return false; } 
            if (valor < nodo.Dato)
            {
                return busqueda(valor, nodo.Izq);
            }
            else if (valor > nodo.Dato)
            {
                return busqueda(valor, nodo.Der);
            }
            return true; 
        }

        public void PodarSubarbolIzquierdo(ref NodoBinario nodo)
        {
            if (nodo != null)
            {
                nodo.Izq = null; 
            }
        }

        public void PodarSubarbolDerecho(ref NodoBinario nodo)
        {
            if (nodo != null)
            {
                nodo.Der = null; 
            }
        }

        public NodoBinario BuscarMinimo(NodoBinario nodo)
        {
            if (nodo == null)
                return null; 

            while (nodo.Izq != null)
            {
                nodo = nodo.Izq;
            }
            return nodo; 
        }

        
        public NodoBinario BuscarMaximo(NodoBinario nodo)
        {
            if (nodo == null)
                return null;

            
            while (nodo.Der != null)
            {
                nodo = nodo.Der;
            }
            return nodo; 
        }

        public void EliminarNodoPorPredecesor(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null) return;

            // Buscar el nodo a eliminar
            if (Dato < Nodo.Dato)
                EliminarNodoPorPredecesor(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                EliminarNodoPorPredecesor(Dato, ref Nodo.Der);
            else
            {
                // Caso 1: El nodo a eliminar tiene dos hijos
                if (Nodo.Izq != null && Nodo.Der != null)
                {
                    // Buscar el predecesor (el nodo más grande del subárbol izquierdo)
                    NodoBinario predecesor = BuscarMaximo(Nodo.Izq);
                    Nodo.Dato = predecesor.Dato; // Reemplazamos el valor por el predecesor
                    EliminarNodoPorPredecesor(predecesor.Dato, ref Nodo.Izq); // Eliminar el predecesor
                }
               
                else if (Nodo.Izq == null)
                {
                    Nodo = Nodo.Der; // Reemplazamos el nodo por su hijo derecho (si existe)
                }
                else if (Nodo.Der == null)
                {
                    Nodo = Nodo.Izq; // Reemplazamos el nodo por su hijo izquierdo (si existe)
                }
            }
        }

        public void EliminarNodoPorSucesor(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null) return;

           
            if (Dato < Nodo.Dato)
                EliminarNodoPorSucesor(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                EliminarNodoPorSucesor(Dato, ref Nodo.Der);
            else
            {
               
                if (Nodo.Izq != null && Nodo.Der != null)
                {
                    
                    NodoBinario sucesor = BuscarMinimo(Nodo.Der);
                    Nodo.Dato = sucesor.Dato; 
                    EliminarNodoPorSucesor(sucesor.Dato, ref Nodo.Der); 
                }
               
                else if (Nodo.Izq == null)
                {
                    Nodo = Nodo.Der; 
                }
                else if (Nodo.Der == null)
                {
                    Nodo = Nodo.Izq; 
                }
            }
        }

        public void RecorridoPorNiveles(NodoBinario nodo)
        {
            if (nodo == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            Queue<NodoBinario> cola = new Queue<NodoBinario>(); 
            cola.Enqueue(nodo);  

            while (cola.Count > 0)  
            {
                NodoBinario nodoActual = cola.Dequeue();  
                strRecorrido += nodoActual.Dato + ", ";  

                if (nodoActual.Izq != null)
                {
                    cola.Enqueue(nodoActual.Izq);
                }

                if (nodoActual.Der != null)
                {
                    cola.Enqueue(nodoActual.Der);
                }
            }
        }

        public int ObtenerAltura(NodoBinario nodo)
        {
            if (nodo == null)
                return 0; 

            int alturaIzq = ObtenerAltura(nodo.Izq);
            int alturaDer = ObtenerAltura(nodo.Der);

            return Math.Max(alturaIzq, alturaDer) + 1;
        }

        public int ObtenerCantidadDeHojas(NodoBinario nodo)
        {
            if (nodo == null)
                return 0; 

            if (nodo.Izq == null && nodo.Der == null)
                return 1;

            int hojasIzq = ObtenerCantidadDeHojas(nodo.Izq);
            int hojasDer = ObtenerCantidadDeHojas(nodo.Der);

            return hojasIzq + hojasDer;
        }

        public int ObtenerCantidadDeNodos(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            int nodosIzq = ObtenerCantidadDeNodos(nodo.Izq);
            int nodosDer = ObtenerCantidadDeNodos(nodo.Der);

           return 1 + nodosIzq + nodosDer;
        }

        public bool ArbolBiCompleto(NodoBinario nodo, int indice, int numeroNodos)
        {
            if (nodo == null)
                return true; 

            if (indice >= numeroNodos)
                return false;

            bool izquierdaCompleto = ArbolBiCompleto(nodo.Izq, 2 * indice + 1, numeroNodos);
            bool derechaCompleto = ArbolBiCompleto(nodo.Der, 2 * indice + 2, numeroNodos);

            return izquierdaCompleto && derechaCompleto;
        }

        public int ContarNodos(NodoBinario nodo)
        {
            if (nodo == null)
                return 0; 
          
            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }
        public bool ArbolBiLleno(NodoBinario nodo)
        {
           
            if (nodo == null)
                return true;
 
            if (nodo.Izq == null && nodo.Der == null)
                return true;

            if (nodo.Izq == null || nodo.Der == null)
                return false;

            return ArbolBiLleno(nodo.Izq) && ArbolBiLleno(nodo.Der);
        }

    }
}
