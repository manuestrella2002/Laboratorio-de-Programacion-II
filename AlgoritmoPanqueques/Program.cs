using System;
using System.Linq;

namespace AlgoritmoPanqueques
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Random();
            int[] TorrePanqueques= new int[6];
            for (int i = 0; i < TorrePanqueques.Length; i++)
            {
                TorrePanqueques[i] = a.Next(1,6);
                Console.WriteLine(TorrePanqueques[i]);
            }
            int tam = TorrePanqueques.Length;
            int max = 0;
            int posmax=0;

            for (int j = 0; j < tam; j++)
            { 
                for (int i = 0; i < tam; i++)
                {
                    if (TorrePanqueques[i] > max)
                    {
                        max = TorrePanqueques[i];
                        posmax = i;
                       
                    }
                }
                Array.Reverse(TorrePanqueques, posmax, tam);
                Console.WriteLine("{0}", TorrePanqueques);
                tam--;
            }
            Array.Reverse(TorrePanqueques);

        }
    }
}
