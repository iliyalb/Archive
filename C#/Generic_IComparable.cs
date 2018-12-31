using System;
using System.Collections.Generic;

namespace Generic_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void sort<T>(T p1, T p2) where T : IComparable <T>
        {
            if (p1.CompareTo(p2) > 0)
            {
                System.Console.WriteLine(p1 + ", " + p2);
            }
            else
            {
                System.Console.WriteLine(p2 + ", " + p1);   
            }
        } 
    }
}