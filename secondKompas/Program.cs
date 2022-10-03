using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondKompas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1");
            Console.Write("Введите число (0<a<366): ");
            int a = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(1, 1, 1);
            Console.WriteLine($"Число {a} соответствует: {date.AddDays(a - 1).ToString("dd MMMM")}");

            Console.WriteLine("Упражнение 4.2");
            Console.Write("Введите число от 1 до 365: ");
            int b = int.Parse(Console.ReadLine());
            if (b < 1 || b > 365)
            {
                Console.WriteLine("Вы ввели неправильное число!");
            }
            else
            {
                DateTime date1 = new DateTime(1, 1, 1);
                Console.WriteLine($"Число {b} соответствует: {date1.AddDays(b - 1).ToString("dd MMMM")} ");
            }

            Console.WriteLine("ДЗ 4.1");
            Console.Write("Введите число от 1 до 365: ");
            int c = int.Parse(Console.ReadLine());
            if (c < 1 || c > 365)
            {
                Console.WriteLine("Вы ввели неправильное число!");
            }
            else
            {
                DateTime data = new DateTime(1, 1, 1);
                Console.WriteLine($"Число {c} соответствует: {data.AddDays(c - 1).ToString("dd MMMM")}");
                Console.Write("Введите год:");
                int year = int.Parse(Console.ReadLine());
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("год високосный");
                }
                else
                {
                    Console.WriteLine("год не високосный");
                }
            }
        }
    }
}
