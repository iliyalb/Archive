using System;

namespace Program
{
    delegate void Hello(string name);

    class Program
    {
        static void Main(string[] args)
        {
            Hello hi = delegate (string name)
            {
                Console.WriteLine("Hello " + name);
            };

            hi("John");
        }
    }
}