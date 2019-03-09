using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_StaticConstructor
{
    class Test
    {
        public static int i;
        public Test()
        {
            Console.WriteLine("Constructor...");
        }
        //public Test(int i, int j) { }
        static Test()
        {
            Console.WriteLine("Static Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Test.i = 10;
            //Test oTest = new Test();
            
            Test oTest = new Test();
            Test oTest1 = new Test();
            Test oTest2 = new Test();
            
            Test.i = 10;
            Console.ReadKey();
        }
    }
}
