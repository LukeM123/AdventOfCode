using System;
using System.Linq;

namespace AOC2015D2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int ribbon = 0;
            int l; int w; int h;
            foreach (string myString in System.IO.File.ReadAllLines(@"C:\Users\lukem\source\repos\AdventOfCode\2015\Day2\Input.txt"))
            {
                string[] x = myString.Split('x');
                l = Convert.ToInt32(x[0]);
                w = Convert.ToInt32(x[1]);
                h = Convert.ToInt32(x[2]);

                int[] areas = new int[3];
                areas[0] = l * w;
                areas[1] = w * h;
                areas[2] = l * h;

                int[] sides = new int[3];
                sides[0] = l * 2 + w * 2;
                sides[1] = w * 2 + h * 2;
                sides[2] = h * 2 + l * 2;

                int extra = l * w;
                int equation = ((2 * l * w) + (2 * w * h) + (2 * h * l)) + areas.Min();
                int ribbonEquation = l * w * h + sides.Min();
                ribbon = ribbon + ribbonEquation;
                total = total + equation;
            }
            Console.WriteLine(total.ToString());
            Console.WriteLine(ribbon.ToString());
        }
    }
}
