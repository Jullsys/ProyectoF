using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Ordenamiento.Clases
{
    public class Shellsort
    {
        private int[] lista;
        private Random rand = new Random();
        private Dictionary<int, List<int>> hashTabla;

        public void OrdenarLista()
        {
            if (lista == null || lista.Length == 0)
            {
                throw new InvalidOperationException("La lista no ha sido generada.");
            }

            ShellSort(lista);
        }

        public void GenerarListaAleatoria(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor que cero.");
            }

            lista = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                lista[i] = rand.Next(1, 100); 
            }
            TablaHash();
        }

        public int[] GetLista()
        {
            if (lista == null)
            {
                throw new InvalidOperationException("La lista no ha sido generada.");
            }
            return lista;
        }

        private void ShellSort(int[] array)
        {
            int n = array.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = temp;
                }
            }
        }

        public void OrdenarListaRadix()
        {
            if (lista == null || lista.Length == 0)
            {
                throw new InvalidOperationException("La lista no ha sido generada.");
            }

            int m = lista.Max();  
            for (int exp = 1; m / exp > 0; exp *= 10)
            {
                CuentaPorDigito(lista, exp);  
            }
        }

        private void CuentaPorDigito(int[] array, int exp)
        {
            int[] output = new int[array.Length];
            int[] count = new int[10]; 

            for (int i = 0; i < array.Length; i++)
            {
                int index = (array[i] / exp) % 10;
                count[index]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int index = (array[i] / exp) % 10;
                output[count[index] - 1] = array[i];
                count[index]--;
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = output[i];
            }
        }
        public int BuscarBinario(int numeroBuscado)
        {
            int izquierda = 0;
            int derecha = lista.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;

                if (lista[medio] == numeroBuscado)
                {
                    return medio;  
                }
                else if (lista[medio] < numeroBuscado)
                {
                    izquierda = medio + 1;  
                }
                else
                {
                    derecha = medio - 1; 
                }
            }

            return -1; 
        }

        private void TablaHash()
        {
            hashTabla = new Dictionary<int, List<int>>();

            foreach (int numero in lista)
            {
                int clave = ObtClaveHash(numero);

                if (!hashTabla.ContainsKey(clave))
                {
                    hashTabla[clave] = new List<int>();
                }

                hashTabla[clave].Add(numero);
            }
        }

        private int ObtClaveHash(int numero)
        {
            return numero % 10;  
        }

        public bool BuscarPorHash(int numeroBuscado)
        {
            int clave = ObtClaveHash(numeroBuscado);

            if (hashTabla.ContainsKey(clave))
            {
                return hashTabla[clave].Contains(numeroBuscado);
            }

            return false;  
        }

    }
}
