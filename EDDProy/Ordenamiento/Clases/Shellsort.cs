using System;
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
        private Random rand = new Random();  // Instanciamos Random una sola vez

        // Método de ShellSort
        public void OrdenarLista()
        {
            if (lista == null || lista.Length == 0)
            {
                throw new InvalidOperationException("La lista no ha sido generada.");
            }

            ShellSort(lista);
        }

        // Método para generar la lista aleatoria
        public void GenerarListaAleatoria(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor que cero.");
            }

            lista = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                lista[i] = rand.Next(1, 100);  // Genera números aleatorios entre 1 y 100
            }
        }

        // Método que devuelve la lista actual
        public int[] GetLista()
        {
            if (lista == null)
            {
                throw new InvalidOperationException("La lista no ha sido generada.");
            }
            return lista;
        }

        // Algoritmo ShellSort
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

    }
}
