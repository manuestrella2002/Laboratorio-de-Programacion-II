using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_Recursion
{
    class Program
    {

        static int Vocales(string Palabra)
        {
            int acum;
            if (Palabra.Length==0)
            {
                return 0;

            }
            if(Palabra[Palabra.Length-1]=='a'|| Palabra[Palabra.Length - 1] == 'e'|| Palabra[Palabra.Length - 1] == 'i'|| Palabra[Palabra.Length - 1] == 'o'|| Palabra[Palabra.Length - 1] == 'u')
            {
                acum++;
                return Vocales(Palabra.Substring(0, Palabra.Length - 1) + acum);
            }
            else
            {
                return Vocales(Palabra.Substring(0, Palabra.Length - 1));
            }

        }
        static void Main(string[] args)
        {

            string texto = "Hola" ;
            Console.WriteLine("La cantidad de vocales es: {0}", Vocales(texto));

        }
    }
}
