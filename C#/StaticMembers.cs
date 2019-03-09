using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person naderi = new Person();
            Person habibi = new Person();

            Person.Number1 = 10;
            Person.Number2 = 20;
            int sum = Person.Sum();
            Console.WriteLine(sum.ToString());
            Console.ReadKey();
        }
    }

    class Person
    {
        public int Bini { get; set; }
        public static int Hava { get; set; }

        public static int Number1 { get; set; }
        public static int Number2 { get; set; }
        public static int Sum()
        {
            return Number1 + Number2;
        }
    }
}
