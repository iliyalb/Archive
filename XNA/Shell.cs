using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// Calculates height and distance of a fired shell
    /// </summary>

    class Program
    {
        /// <summary>
        /// Calculates height and distance of a fired shell
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            const float G = 9.8f;

            // print welcome message
            Console.WriteLine("This app calculates the max height and");
            Console.WriteLine("horizontal distance a shell travels based");
            Console.WriteLine("on an initial angle and speed");
            Console.WriteLine();

            // prompt for, get, and convert angle
            Console.WriteLine("Enter angle (in degrees): ");
            float theta = float.Parse(Console.ReadLine());
            theta = theta * (float)Math.PI / 180;

            // prompt for and get speed
            Console.Write("Enter speed (m/s):       ");
            float speed = float.Parse(Console.ReadLine());

            // calculate vox and voy
            float vox = speed * (float)Math.Cos(theta);
            float voy = speed * (float)Math.Sign(theta);

            // calculate t, h, and dx
            float t = voy / G;
            float h = voy * voy / (2 * G);
            float dx = vox * 2 * t;

            //print height and horizontal distance
            Console.WriteLine();
            Console.WriteLine("Maximum height:          " + h + " meters");
            Console.WriteLine("Horizontal distance:     " + dx + " meters");

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
