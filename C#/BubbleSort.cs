using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 90, 5 };

            array = BubbleSort(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 1; i < n; i++)
                for (int j = 0; j < n - i; j++)
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }

            return a;
        }
    }
}