using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, age, height, weight;

            Console.Write("Введите имя: ");
            firstName = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            lastName = Console.ReadLine();

            Console.Write("Введите возраст: ");
            age = Console.ReadLine();

            Console.Write("Введите рост: ");
            height = Console.ReadLine();

            Console.Write("Введите вес: ");
            weight = Console.ReadLine();

            Console.WriteLine("Используя операцию склеивания:");
            Console.WriteLine("Результат анкеты: " + " " + lastName + " " + firstName + " " + age + " " + height + " " + weight);
            Console.WriteLine("Используя операцию форматированного вывода:");
            Console.WriteLine("Результат анкеты: {0} {1} {2} {3} {4} ", lastName, firstName, age, height, weight);
            Console.WriteLine("Используя операцию вывода со знаком $:");
            Console.WriteLine($"Результат анкеты: { lastName} {firstName} {age} {height} {weight}");
        }
    }
}
