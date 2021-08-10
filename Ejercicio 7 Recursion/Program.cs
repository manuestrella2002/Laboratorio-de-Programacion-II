using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribir una función recursiva que encuentra y 
 * devuelve la suma de los elementos en
 * un array entero.
 */


namespace Ejercicio_7_Recursion
{
    class Program
    {
        static int Suma(int[] num_, int n)
        {
            if (n==0)
            {
                return num_[0];
            }
            else
            {
                return Suma(num_, n - 1) + num_[n-1];
            }
        }


        static void Main(string[] args)
        {
            int[] vector = new int[] {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("La suma es: {0}", Suma(vector, 10)-1);


        }
    }
}
