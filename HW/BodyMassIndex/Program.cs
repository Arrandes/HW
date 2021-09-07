using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, h;
            int weight;

            Console.Write("Введите ваш рост в сантиметрах: ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Введите ваш вес: ");
            weight = int.Parse(Console.ReadLine());

            h = height / 100;
            Console.WriteLine($"Индекс массы тела: { Math.Round((weight / (h * h)), 0)}");
        }
    }
}
