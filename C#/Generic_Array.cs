using System;
using System.Collections.Generic;

namespace Generic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void PrintArray<T> (T[] inputArray)
        {
            foreach (T element in inputArray)
            {
                System.Console.WriteLine(element + " ");
            }
            System.Console.WriteLine("\n");
        }
    }
}