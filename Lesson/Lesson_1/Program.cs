using System;

namespace project {

    class Program {

        static void Main() {
            /*Console.Write("Введите число с точкой: ");
            float user_input = float.Parse(Console.ReadLine()!);

            float result;
            result = user_input + 10f;
            result *= 2f; // аналогично result = result * 2f;
            result --; // отнять еденицу (1)

            Console.WriteLine("Переменная " + result);
            */

            // Console.WriteLine(Math.PI); - константа выводящая число Пи
            // Console.WriteLine(Math.Abs(-20)); - константа модуля, выводит модуль от числа
            // Console.WriteLine(Math.Ceiling(5.11f)); - константа округляет к большему числу
            // Console.WriteLine(Math.Floor(5.99f)); - константа округляет к меньшему числу
            // Console.WriteLine(Math.Round(5.45f)); - константа округления к большему или меньшему
            // Console.WriteLine(Math.Max(5, 2)); - вывод масимального числа из списка (Min) минимального
            // Console.WriteLine(Math.Pow(5, 2)); - возводим в степень 2, число 5 (либо куб, миняем 2 на 3)

            Console.WriteLine("Введите радиус круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);
        }

    }

}
