using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number1 = 10;
            //int x = 20;
            //int havij = 30;

            //Array
            //int[] intArray1 = new int[3];
            //intArray1[0] = 10;
            //intArray1[1] = 20;
            //intArray1[2] = 30;
            //Console.WriteLine(intArray1[1]);
            //Console.WriteLine(intArray1[0]);



            //string[] strArray2 = new string[3];
            //strArray2[0] = "Mehrdad Naderi";
            //strArray2[1] = "Mohammad Mohammadi";
            //strArray2[2] = "Shirin Shirini";
            //Console.WriteLine(strArray2[0]);



            //Array Initializer
            //int[] intArray3 = { 10, 20, 30, 40 };
            //Console.WriteLine(intArray3[2]);



            //string[] strArray4 = { "Mehrdad Naderi", "Shirin Shirini" };
            //Console.WriteLine(strArray4[0]);



            //int[,] RectangularArray5 = new int[3, 4];
            //RectangularArray5[0, 0] = 10;
            //RectangularArray5[0, 1] = 20;
            //RectangularArray5[0, 2] = 30;
            //RectangularArray5[0, 3] = 40;
            //RectangularArray5[1, 0] = 50;
            //RectangularArray5[1, 1] = 60;
            //RectangularArray5[1, 2] = 70;
            //RectangularArray5[1, 3] = 80;
            //RectangularArray5[2, 0] = 90;
            //RectangularArray5[2, 1] = 10;
            //RectangularArray5[2, 2] = 20;
            //RectangularArray5[2, 3] = 30;
            //Console.WriteLine(RectangularArray5[1, 2]);



            //int[,] RectangularArray6 = { { 10, 20, 30, 40 }, { 50, 60, 70, 80 }, { 90, 10, 20, 30 } };
            //Console.WriteLine(RectangularArray6[1,2]);



            //JaggedArray = Array of Arrays
            //int[][] JaggedArray7 = new int[3][];
            //JaggedArray7[0] = new int[5];
            //JaggedArray7[1] = new int[5000];
            //JaggedArray7[2] = new int[3];
            //JaggedArray7[0][0] = 1;
            //JaggedArray7[0][1] = 2;
            //JaggedArray7[0][2] = 3;
            //System.Console.WriteLine(JaggedArray7[0][1]);



            //int[][] JaggedArray8 = { new int[] { 1, 2, 3, 4 }, 
            //                           new int[] { 1, 2, 3, 4, 5, 6, 7 }, 
            //                           new int[] { 1, 2, 3 } };


            int[][,] JaggedArray9 = new int[3][,] { 
                new int[,]{ {1, 3}, {5, 7} }, 
                new int[,]{ {0, 2}, {4, 5}, {6, 7} }, 
                new int[,]{ {11, 22}, {44, 55} }
            };

            Console.ReadKey();
        }
    }
}
