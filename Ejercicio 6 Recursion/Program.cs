using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_Recursion
{ 
    class Program
    {
        static int SumaCuadrados(int N)
        {
            if (N < 0)
            {
                N = -N;
            }

            if (N == 0)
            {
                return 0;
            }
            else
            {
                return SumaCuadrados(N - 1) + (int)Math.Pow(N, 2);
            }
        }
        static void Main(string[] args)
        {
            int numero = 2;
            Console.WriteLine("La suma de los cuadrados es: {0}", SumaCuadrados(numero));



        }
    }
}
