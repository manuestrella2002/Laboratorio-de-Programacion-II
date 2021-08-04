using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escriba una función recursiva que diga si una palabra es o no un palíndromo (igual
//leída de derecha a izquierda o de izquierda a derecha).
namespace Ejercicio_4_Recursion
{


    class Program
    { 

        static string Invertir(string texto)
        {
            if (texto.Length == 1)
            {
                return texto;
            }
            else
            {
                return texto[texto.Length - 1] + Invertir(texto.Substring(0, texto.Length - 1));
            }
        }

        static string Palindromo(string texto)
        {
            string aux = texto;
            texto=Invertir(texto);
            if (aux==texto)
            {
                return "Palindromo";
            }
            else
            {
                return "No Palindromo";
            }
        }

        static string Palindromo2(string texto)
        {
            texto=texto.ToLower();

            if (texto.Length % 2==0)
            {
                return "No es Palindromo";
            }

            if (texto.Length<2)
            {
                return "Es palindromo";
            }

            if (texto[0]==texto[texto.Length - 1])
            {
                return Palindromo2(texto.Substring(1, texto.Length - 2));
            }
            else
            {
                return "No es Palindromo";
            }


        }


        static void Main(string[] args)
        {
            string palabra;
            Console.WriteLine("Ingrese una palabra:");
            palabra = Console.ReadLine();
            Console.WriteLine("La palabra es " + Palindromo2(palabra));

        }
    }
}
