using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static double MathCoordinates(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            int x1, x2, y1, y2;

            Console.Write("Пожалуйста, ведите координаты точки x1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, ведите координаты точки x2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, ведите координаты точки y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Пожалуйста, ведите координаты точки y2: ");
            y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат: {0:F2}", MathCoordinates(x1, x2, y1, y2));
        }
    }
}
