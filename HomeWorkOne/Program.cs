using System;

namespace HomeWorkOne
{
    //Задания выполнил: Скворцов Александр
    class Program
    {
        //Метод к 6 заданию
        static void Print(string str)
        {
            Console.WriteLine(str);
        }
        //Метод к 6 заданию
        static void Pause()
        {
            Console.ReadKey();
        }
        //Метод к 5 заданию
        static void Position(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        //Метод к 3 заданию
        static double MathCoordinates(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            #region Задание 1
            /*
             * Выполнил: Скворцов Александр
             * Написать программу «Анкета».
             * Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
             * В результате вся информация выводится в одну строчку.
             * а) используя склеивание;
             * б) используя форматированный вывод;
             * в) используя вывод со знаком $.
             */

            //string firstName, lastName, age, height, weight;
            //Console.Write("Пожалуйста, введите ваше имя: ");
            //firstName = Console.ReadLine();
            //Console.Write("Пожалуйста, введите вашу фамилию: ");
            //lastName = Console.ReadLine();
            //Console.Write("Пожалуйста, введите ваш возраст: ");
            //age = Console.ReadLine();
            //Console.Write("Пожалуйста, введите ваш рост: ");
            //height = Console.ReadLine();
            //Console.Write("Пожалуйста, введите ваш вес: ");
            //weight = Console.ReadLine();

            ////Используя склеивание
            //Console.WriteLine("Полученные данные: " + firstName + " " + lastName + " " + age + " " + height + " " + weight + " ");
            ////Используя форматированный вывод;
            //Console.WriteLine("Полученные данные: {0} {1} {2} {3} {4}",
            //                    firstName,
            //                    lastName,
            //                    age,
            //                    height,
            //                    weight);
            ////Используя вывод со знаком $
            //Console.WriteLine($"Полученные данные {firstName} {lastName} {age} {height} {weight}");
            #endregion
            #region Задание 2
            /*
             * Выполнил: Скворцов Александр
             * Ввести вес и рост человека.
             * Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); 
             * где m — масса тела в килограммах, h — рост в метрах
            */
            //Console.Write("Пожалуйста, введите ваш рост в сантиметрах: ");
            //double height = double.Parse(Console.ReadLine());
            //Console.Write("Пожалуйста, введите ваш вес: ");
            //int weight = int.Parse(Console.ReadLine());

            //double h = height / 100;
            //Console.WriteLine($"Индекс массы тела: { Math.Round((weight / (h * h)), 0)}");
            #endregion
            #region Задание 3
            /*
             * Выполнил: Скворцов Александр
             * а) Написать программу, которая подсчитывает расстояние между точками с координатами 
             * x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
             * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
             * б) Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
             */

            //int x1, x2, y1, y2;
            //Console.Write("Пожалуйста, введите x1: ");
            //x1 = int.Parse(Console.ReadLine());
            //Console.Write("Пожалуйста, введите x2: ");
            //x2 = int.Parse(Console.ReadLine());
            //Console.Write("Пожалуйста, введите y1: ");
            //y1 = int.Parse(Console.ReadLine());
            //Console.Write("Пожалуйста, введите y2: ");
            //y2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ответ: {0:F2}", MathCoordinates(x1, x2, y1, y2));
            #endregion
            #region Задание 4
            /*
             * Выполнил: Скворцов Александр
             * Написать программу обмена значениями двух переменных.
             * а) с использованием третьей переменной;
             * б) без использования третьей переменной.
             */

            //int a, b, c;
            //Console.Write("Введите значение для переменной a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Введите значение для переменной b: ");
            //b = int.Parse(Console.ReadLine());

            ////С использованием третьей переменной;
            ////c = a;
            ////a = b;
            ////b = c;

            ////Без использования третьей переменной
            //a = a + b;
            //b = a - b;
            //a = a - b;

            //Console.WriteLine("Значение переменной a: " + a);
            //Console.WriteLine("Значение переменной b: " + b);
            #endregion
            #region Задание 5
            /*
             * Выполнил: Скворцов Александр
             * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
             * б) Сделать задание, только вывод организуйте в центре экрана
             * в) Сделать задание б с использованием собственных методов 
             * (например, Print(string ms, int x,int y)
             */

            //Position(42, 12);
            //Console.WriteLine("Скворцов Александр, Санкт-Петербург");
            #endregion
            #region Задание 6
            /*
             * Выполнил: Скворцов Александр
             * 6. Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
             */
            Print("Hello!");
            Pause();
            #endregion
        }
    }
}
