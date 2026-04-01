using System;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: 
            //  «валету» – 11, «даме» – 12, «королю» – 13, «тузу» – 17 
            //  Порядковые номера остальных карт соответствуют их названиям(«шестерка», «девятка» и т.п.).
            //  По заданному номеру карты k(6 ≤ k ≤ 14) определить достоинство соответствующей карты.
            for(int i = 0; i < 14; ++i)
            {

            
            int number = 0;
        number:
            Console.Write($"Введите порядковый номер [6:14]: ");
            try
            {
                number = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {e.Message}\nПопробуйте снова\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Нажмите чтобы продолжить . . .");
                Console.ReadKey();
                Console.Clear();
                goto number;
            }
                switch (number)
                {
                    case 6:
                        Console.WriteLine($"Введена карта под номером {number}\nЭто \"Шестёрка\" с достоинством 6");
                        break;

                    case 7:
                        Console.WriteLine($"Введена карта под номером {number}\nЭто \"Семёрка\" с достоинством 7");
                        break;

                    case 8:
                        Console.WriteLine($"Введена карта под номером {number}\nЭто \"Восмёрка\" с достоинством 8");
                        break;

                    case 9:
                        Console.WriteLine($"Введена карта под номером {number}\nЭто \"Девятка\" с достоинством 9");
                        break;

                    case 10:
                        Console.WriteLine($"Введена карта под номером {number}\nЭто \"Десятка\" с достоинством 10");
                        break;

                    case 11:
                        Console.WriteLine($"Введена карта под номером {number}\nЭто \"Валет\" с достоинством 11");
                        break;

                    case 12:
                        Console.WriteLine($"Введена карта под номером {number}\nЭто \"Дама\" с достоинством 12");
                        break;

                    case 13:
                        Console.WriteLine($"Введена карта под номером {number}\nЭто \"Король\" с достоинством 13");
                        break;

                    case 14:
                        Console.WriteLine($"Введена карта под номером {number}\nЭто \"Туз\" с достоинством 17");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Порядковый номер может лежать только в диапозоне [6:14]");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Нажмите чтобы продолжить . . .");
                        Console.ReadKey();
                        Console.Clear();
                        goto number;
                }
                
            }
            Console.ReadKey();
        }
    }
}
