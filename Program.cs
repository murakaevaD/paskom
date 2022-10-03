using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("мармелад");
            //    enum Carts
            //{
            //    Шестерка = 6,
            //    Семерка = 7,
            //    Восьмерка = 8,
            //    Девятка = 9,
            //    Десятка = 10,
            //    Валет = 11,
            //    Дама = 12,
            //    Король = 13,
            //    Туз = 14
            //}
            //enum Week
            //{
            //    Понедельник = 1,
            //    Вторник = 2,
            //    Среда = 3,
            //    Четверг = 4,
            //    Пятницa = 5,
            //    Суббота = 6,
            //    Воскресенье = 7
            //}
            //Console.WriteLine("номер 1 Вася и форточка");
            //Console.Write("Введите длину форточки: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Введите ширину форточки: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Введите диаметр головы Васи: ");
            //double d = double.Parse(Console.ReadLine());
            //double a1 = a + 1;
            //double b1 = b + 1;
            //if (a1 > d && b1 > d)
            //{
            //    Console.WriteLine("Голова Васи пролезет в форточку");
            //}
            //else
            //{
            //    Console.WriteLine("Голова Васи не пролезет в форточку");
            //}

            //Console.WriteLine("номер 2 таблица умножения");
            //Console.Write("Введите число n (от 1 до 10): ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 11; i++)
            //{
            //    int n1 = n * i;
            //    Console.WriteLine($"{n} x {i} = " + n1);
            //}

            //Console.WriteLine("номер 3 бенгбум делимость");
            //Console.Write("Введите число: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0)
            //{
            //    Console.WriteLine("Бэнг");
            //}
            //else if (num % 5 == 0)
            //{
            //    Console.WriteLine("Бум");
            //}
            //else if ((num % 5 == 0) & (num % 3 == 0))
            //{
            //    Console.WriteLine("БэнгБум");
            //}
            //else
            //{
            //    Console.WriteLine("Мимо");
            //}

            //Console.WriteLine("номер 4 проверка заглавных букв");
            //Console.Write("Введите слово: ");
            //string word = Console.ReadLine();
            //bool mess;
            //if (mess = word.All(Char.IsUpper))
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //Console.WriteLine("номер 5 овца ");
            //Console.Write("Введите число: ");
            //int z = int.Parse(Console.ReadLine());
            //for (int z1 = 1; z1 <= z; z1++)
            //{
            //    Console.Write(z1 + " овца ... ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("номер 6 среднее арифметическое всех чисел непустой последовательности");
            //try
            //{
            //    int[] chisla = { 91, 7, 80, 3, 1, -1 };
            //    int v = chisla.Count(m => m > 0);
            //    int sum = chisla.Sum();
            //    Console.WriteLine($"Среднее арифметическое: {(double)sum / v}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("На ноль делить нельзя");
            //}

            //Console.WriteLine("номер 7 игральные карты");
            //Console.Write("Введите номер карты от 6 до 14: ");
            //try
            //{
            //    byte cart = byte.Parse(Console.ReadLine());
            //    if (cart >= 6 && cart <= 14)
            //    {
            //        Console.WriteLine($"Карта - {(Carts)cart}");
            //    }
            //    else
            //        Console.WriteLine("Номер введен неверно");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Номер введен неверно");
            //}

            //Console.WriteLine("номер 8 сколько кукол в сумке");
            //string[] symka = { "Hello Kitty", "Barbie doll", "pig", "dog", "sheep", "Barbie doll", "bus", "Hello Kitty" };
            //int t = 0;
            //foreach (string str in symka)
            //{
            //    if (str == "Hello Kitty" || str == "Barbie doll")
            //    {
            //        t++;
            //    }
            //}
            //Console.WriteLine($"В сумке {t} куклы");

            //Console.WriteLine("номер 9 дни недели");
            //Console.Write("Введите номер дня в неделе: ");
            //byte den = byte.Parse(Console.ReadLine());
            //if (den > 7 || den < 1)
            //{
            //    Console.WriteLine("День не придумали на эту цифру");
            //}
            //else
            //{
            //    Console.WriteLine($"День недели - {(Week)den}");
            //}

            //Console.WriteLine("номер 10 сортировка массива при помощи пузырька");
            //int[] arr = { 67, 7474, 2, 44, -574, 7, 324, 32 };

            //int q = 0;

            //for (int w = 0; w < arr.Length; w++)
            //{
            //    for (int e = 0; e < arr.Length - 1; e++)
            //    {
            //        if (arr[e] > arr[e + 1])
            //        {
            //            q = arr[e + 1];
            //            arr[e + 1] = arr[e];
            //            arr[e] = q;
            //        }
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++)
            //    Console.Write(arr[i] + " ");
            //Console.WriteLine();
            //Console.WriteLine("Сортировка массива с помощью встроенных методов ");
            //Array.Sort(arr);
            //foreach (int I in arr)
            //    Console.Write(I + " ");
            //Console.WriteLine();

            //Console.WriteLine("номер 11 есть ли эта последовательность упорядоченной по возрастанию");
            //const byte o = 10;
            //int[] p = new int[o];
            //for (int i = 0; i < o; i++)
            //{
            //    Console.Write("Введите " + i + " элемент последовательности: ");
            //    p[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 1; i < p.Length; i++)
            //{
            //    if (p[i] <= p[i - 1])
            //    {
            //        Console.WriteLine(p[i]);
            //        break;
            //    }
            //}
            //Console.ReadKey();
        }
    }
}
