using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?

            double sircle_r = 0;
            double square_r = 0;

        sircle:
            Console.Write($"Введите радиус  круга: ");
            try
            {
                sircle_r = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {e.Message}\nПопробуйте снова\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto sircle;
            }

        square:
            Console.Write($"Введите сторону квадрата: ");
            try
            {
                square_r = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {e.Message}\nПопробуйте снова\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto square;
            }

            double S_square = square_r * square_r;
            double S_sircle = sircle_r * Math.PI * 2;

            Console.WriteLine($"Площадь круга = {S_sircle:F2}\nПлощадь квадрата = {S_square}");
            
            Console.ForegroundColor = ConsoleColor.Green;
            if (S_sircle > S_square)
            {
                Console.WriteLine($"Площадь круга больше площади квадрата");
            }
            else
            {
                Console.WriteLine($"Площадь квадрата больше площади круга");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
