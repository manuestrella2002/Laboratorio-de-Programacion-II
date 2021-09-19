using System;

namespace Torres_de_Hanoi
{
	class Program
	{

		static void hanoi(int n, char source, char auxiliary, char target)
		{
			if (n > 0)
			{
				hanoi(n - 1, source, target, auxiliary);
				Console.WriteLine("{0}-->{1}", source, target);
				hanoi(n - 1, auxiliary, source, target);
			}
		}

		static int numMovs(int n)
		{
			int movs = 0;
			if (n > 0)
			{
				movs = 2 * numMovs(n - 1) + 1;
			}
			return movs;
		}
		static void Main(string[] args)
		{
			int num;
			Console.WriteLine("Torres de Hanoi"); ;
			Console.WriteLine("Numero de dicos");
			num = Convert.ToInt32(Console.ReadLine());
			hanoi(num, 'A', 'B', 'C');
			Console.WriteLine("Resuelto!");
			Console.WriteLine("Numero de movimientos:{0}", Convert.ToString(numMovs(num)));

		}


	}
}
