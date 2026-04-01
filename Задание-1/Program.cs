using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Даны два различных вещественных числа.
            //    Определить: 
            //    а) какое из них больше;
            //    б) какое из них меньше.

            double a = 0;
            double b = 0;

        number_a:

            Console.Write($"Введите первое число: ");
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {e.Message}\nПопробуйте снова\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto number_a;
            }

        number_b:
            Console.Write($"Введите второе число: ");
            try
            {
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {e.Message}\nПопробуйте снова\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto number_b;
            }

            Console.Write($"Пункт а:");

            if (a > b)
            {
                Console.WriteLine($"Число {a} больше");
            }
            else
            {
                Console.WriteLine($"Число {b} больше");
            }

            Console.Write($"Пункт б:");

            if (a < b)
            {
                Console.WriteLine($"Число {a} меньше ");
            }
            else
            {
                Console.WriteLine($"Число {b} больше");
            }
            Console.ReadKey();
        }
    }
}
