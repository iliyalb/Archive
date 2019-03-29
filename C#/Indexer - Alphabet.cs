using System;

namespace Program
{
    class Alphabet
    {
        //Indexer
        public char this[int index]
        {
            get
            {
                return (char)index;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate
            Alphabet alpha = new Alphabet();

            //Input
            Console.Write("How many chars to display? (0-25): ");
            int limit = int.Parse(Console.ReadLine());

            //Exception
            if (limit < 0 || limit > 25)
                throw new ApplicationException("Invalid input");

            //Output
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(alpha[i + 97] + " ");
            }

            Console.ReadKey();
        }
    }
}