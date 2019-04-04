using System;

namespace Program
{
    class Sequence
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            SequenceSearch(a, 3);
        }

        public static void SequenceSearch(int[] a, int x)
        {
            int n = a.Length;

            for (int i = 0; i < n; i++)
                if (x == a[i])
                {
                    Console.WriteLine("{0} ---> A[{1}]", x, i);
                    return;
                }

            Console.WriteLine("Not found");
        }
    }
}
