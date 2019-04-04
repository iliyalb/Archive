using System;

namespace Program
{
    internal class Anonymous
    {
        private delegate void MyDelegate(int end);

        static void Main(string[] args)
        {
            MyDelegate count = delegate (int end)
            {
                for (int i = 0; i <= end; i++)
                    Console.WriteLine(i);
            };

            count(10);
        }
    }
}