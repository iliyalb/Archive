using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car oCar = new Car();
            oCar.Model = "BMW Z4";
            oCar.Price = 100000;
            oCar.ShowInfo();
            Console.ReadKey();
        }
    }
}

// CLASS FILE: Car1.cs
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Learning_PartialClass
// {
//     partial class Car
//     {
//         public int Price { get; set; }
//         public string Model { get; set; }
//     }
// }

// CLASS FILE: Car2.cs
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Learning_PartialClass
// {
//     partial class Car
//     {
//         public void ShowInfo()
//         {
//             Console.WriteLine("My car name is {0} and It's price is {1}", Model, Price);
//         }
//     }
// }

