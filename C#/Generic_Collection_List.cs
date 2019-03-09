using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic.List<int> lst
            //    = new List<int>();

            //lst.Add(100);
            //lst.Add(200);
            //lst.Add(300);
            //lst.Add(400);

            //Console.WriteLine(lst[1]);

            //lst.Remove(200);

            //Console.WriteLine(lst[1]);

            //lst.RemoveAt(1);

            //Console.WriteLine(lst[1]);



            //List<int> lst2 = new List<int>();
            //lst2.Add(5);
            //lst2.Add(2);
            //lst2.Add(4);

            //lst2.Sort();

            //Console.WriteLine(lst2[0]);
            //Console.WriteLine(lst2[1]);
            //Console.WriteLine(lst2[2]);



            List<string> lst3 = new List<string>();
            lst3.Add("Mehrdad Naderi");
            lst3.Add("Shirin Shirini");
            Console.WriteLine(lst3[1]);

            Console.ReadKey();
        }
    }
}
