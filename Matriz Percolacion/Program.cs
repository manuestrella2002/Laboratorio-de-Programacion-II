using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Percolacion
{
    class Program
    {
        public class Percolation
        {
            // Devuelvo una matriz booleana aleatoria de nxn, donde cada entrada tiene una probabilidad p
            // (entre 0 y 100) de estar llena
            public static bool[,] random(int n, int p)
            {
                
                //var rand = new Random(Guid.NewGuid().GetHashCode()); // Sacar el numero entre parentesis para semillas aleatorias
                var rand = new Random(8); // Sacar el numero entre parentesis para semillas aleatorias

                int devuelto;
                bool[,] a = new bool[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        devuelto = rand.Next(0, 100);
                        if (devuelto < p)
                            a[i, j] = true;
                        else
                            a[i, j] = false;
                    }
                return a;
            }

            // Muestro en pantalla la matriz de percolacion que recibo
            public static void mostrar(bool[,] matriz)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1) - 1; j++)
                    {
                        Console.Write(Convert.ToInt32(matriz[i, j]) + " ");
                    }
                    Console.Write(Convert.ToInt32(matriz[i, matriz.GetLength(1) - 1]));
                    Console.WriteLine();
                }
            }

            // Dada una matriz de nxn, siendo true un sitio abierto y false un sitio cerrado
            // devuelve una matriz nxn de sitios accesibles desde la parte superior
            public static bool[,] flujo(bool[,] original)
            {
                int n = original.GetLength(0);
                bool[,] llena = new bool[n, n];
                for (int j = 0; j < n; j++)
                {
                    flujo(original, llena, 0, j); // no es necesario igualarla, ya que C# pasa un puntero
                }
                return llena;
            }

            // determina los sitios llenos usando busqueda en profundidad
            public static void flujo(bool[,] original, bool[,] llena, int i, int j)
            {
                int n = original.GetLength(0);
                if (i >= n || j >= n || i < 0 || j < 0) 
                {
                    return;
                }

                if (original[i, j] == true)
                {
                    llena[i, j] = true;
                    i++;
                    flujo(original, llena, i, j);

                }
                
                if (j>0 && i>0 && original[i-1,j-1]==true)
                {
                    llena[i-1, j - 1] = true;
                    j--;
                    flujo(original, llena, i, j);
                }
                
                /*
                else if (original[i, j] == true)
                {
                    llena[i, j + 1] = true;
                    j++;
                    flujo(original, llena, i, j);
                }
                else if (j > 0 && original[i, j - 1] == true)
                {
                    llena[i, j - 1] = true;
                    j--;
                    flujo(original, llena, i, j);
                }
                */
            }

            // Percola la matriz?
            public static bool percolates(bool[,] original)
            {
                int n = original.GetLength(0);
                bool[,] llena = flujo(original);
                for (int j = 0; j < n; j++)
                {
                    // Si alguna celda de la ultima fila esta llena, devuelvo true
                    if (llena[n - 1, j]) return true;
                }
                return false;
            }

            // Leo la matriz que recibo por teclado y lo guardo en matrizOriginal
            public static bool[,] leerMatriz(int n)
            {
                bool[,] matrizOriginal = new bool[n, n];
                string[] fila;
                for (int i = 0; i < n; i++)
                {
                    fila = (Console.ReadLine().Split(' '));

                    for (int j = 0; j < n; j++)
                    {
                        matrizOriginal[i, j] = Convert.ToBoolean(Convert.ToInt32(fila[j]));
                    }
                }

                return matrizOriginal;
            }

            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine()); //Obtengo el tamanio de la matriz

                Console.WriteLine("-- Matriz Original --");

                bool[,] matrizOriginal = random(n, 50); //Creo la matriz random

                mostrar(matrizOriginal); //Muestro la matriz creada

                Console.WriteLine("---------------");

                bool[,] matrizFlow = flujo(matrizOriginal); // Armo la matriz percolacion

                bool percol = percolates(matrizOriginal); // Pregunto si percola

                mostrar(matrizFlow); // Muestro en pantalla la matriz percolacion

                Console.Write("Percola? {0}", percol);

                Console.ReadKey();

            }
        }
    }
}
