using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_To_Generic
{
    class Test
    {
        //public void Swap1(int i, int j)
        //{
        //    int temp = i;
        //    i = j;
        //    j = temp;
        //    Console.WriteLine("I = {0}, J = {1}", i.ToString(), j.ToString());
        //}

        //public void Swap2(string str1, string str2)
        //{
        //    string temp = str1;
        //    str1 = str2;
        //    str2 = temp;
        //    Console.WriteLine("STR1 = {0}, STR2 = {1}", str1.ToString(), str2.ToString());
        //}


        public void Swap<T>(T arg1, T arg2)
        {
            T temp = arg1;
            arg1 = arg2;
            arg2 = temp;
            Console.WriteLine("Arg1: {0}, Arg2: {1}", arg1, arg2);
        }
    }

    class Test2<T>
    {
        private T myVar;

        public T MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        public T TestMethod(T arg1)
        {
            return arg1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test objTest = new Test();
            //objTest.Swap1(10, 20);
            //objTest.Swap2("Mehrdad", "Naderi");



            objTest.Swap<int>(10, 20);
            objTest.Swap<string>("Mehrdad", "Naderi");
            objTest.Swap<bool>(true, false);
            Console.ReadKey();
        }
    }
}
