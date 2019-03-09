using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Final96_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization
            Matrix oMatrix = new Matrix();
            oMatrix.Set();
            oMatrix.Mul();
            Console.ReadKey();
        }
    }

    class Matrix
    {
        //Arrays
        int[,] a = new int[3, 3];
        int[,] b = new int[3, 3];
        int[,] c = new int[3, 3];

        //Constructor
        public Matrix()
        {
            a[0, 0] = 0;
            a[0, 1] = 0;
            a[0, 2] = 0;
            a[1, 0] = 0;
            a[1, 1] = 0;
            a[1, 2] = 0;
            a[2, 0] = 0;
            a[2, 1] = 0;
            a[2, 2] = 0;
            b[0, 0] = 0;
            b[0, 1] = 0;
            b[0, 2] = 0;
            b[1, 0] = 0;
            b[1, 1] = 0;
            b[1, 2] = 0;
            b[2, 0] = 0;
            b[2, 1] = 0;
            b[2, 2] = 0;
            c[0, 0] = 0;
            c[0, 1] = 0;
            c[0, 2] = 0;
            c[1, 0] = 0;
            c[1, 1] = 0;
            c[1, 2] = 0;
            c[2, 0] = 0;
            c[2, 1] = 0;
            c[2, 2] = 0;
        }

        public void Set()
        {
            try
            {
                //Get a
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("Enter the value for a ({0},{1}): ", i, j);
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                    }

                }

                //Get b
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("Enter the value for b ({0},{1}): ", i, j);
                        b[i, j] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                    }

                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Mul()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] * b[i, j];
                    Console.WriteLine("c ({0},{1}) = {2}",i,j,c[i,j]);
                }

            }
        }
    }
}