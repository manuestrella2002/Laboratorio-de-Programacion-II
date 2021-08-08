using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_04_08_2021
{
    class Program
    {

        static int factorial(int numero)
        {
            if (numero == 0)
            {
                return 1;
            }
            else
            {
                return numero * factorial(numero - 1);
            }
        }

        static string invertir(string texto)
        {
            texto.Substring(1);
            if (texto.Length == 1)
            {
                return texto;
            }
            else
            {
                return texto[texto.Length - 1] + invertir(texto.Substring(0, texto.Length - 1));
            }
        }
        static void Main(string[] args)
        {
            //Console.Write("Hello World!");
            Console.WriteLine("Ingrese un numero");

            //string texto = Console.ReadLine();

            int n = Convert.ToInt32(Console.ReadLine());
            //int a = int.Parse(Console.ReadLine());
            int resul = factorial(n);
            Console.WriteLine("{0} {1} {0}", resul, n);

            Console.WriteLine("Ingrese una palabra:");
            string texto = Console.ReadLine();
            invertir(texto);
        }
    }
}
