using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningConstants
{
    class Test
    {
        public const double pi = 3.14;
        public readonly double pi2 = 3.14;
        public readonly double pi3;
        public static readonly double pi4 = 3.14;
        public static readonly double pi5;

        public Test()
        {
            pi3 = 3.14;
        }

        static Test()
        {
            pi5 = 3.14;
        }

        public void Fu()
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double d = Test.pi;
            Test oTest = new Test();
            double d2 = oTest.pi2;
            double d3 = Test.pi4;
        }
    }
}
