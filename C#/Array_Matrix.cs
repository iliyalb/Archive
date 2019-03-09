using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSG16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] N = new int[5, 5];
            int M = 1;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    N[i, j] = j * M;
                }
                M *= 10;
            }
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Console.Write(N[j, i] + "   ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
