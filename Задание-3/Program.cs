using System;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; ++i)
            {


                int shrooms = 0;
            sircle:
                Console.Write($"Введите количество грибов: ");
                try
                {
                    shrooms = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: {e.Message}\nПопробуйте снова\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Нажмите чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    goto sircle;
                }
                if (shrooms < 0)
                {
                    Console.WriteLine("Вы нашли отрицательное количество грибов?\n");
                    Console.WriteLine("Нажмите чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    goto sircle;
                }
                if (shrooms == 0)
                {
                    Console.WriteLine("Вы не нашли ни одного гриба");
                    goto sircle;
                }

                int remains = shrooms % 10;

                if (remains == 1 && shrooms != 11 && shrooms % 100 != 11)
                {
                    Console.WriteLine($"Вы нашли {shrooms} гриб");
                }
                if (remains > 1 && remains < 5)
                {
                    Console.WriteLine($"Вы нашли {shrooms} гриба");
                }
                if (remains > 4 && remains <= 9 || remains == 0 || shrooms % 100 == 11)
                {
                    Console.WriteLine($"Вы нашли {shrooms} грибов");
                }
                
            }
            Console.WriteLine("Нажмите чтобы выйти из программы");
            Console.ReadKey();
        }
    }
}
