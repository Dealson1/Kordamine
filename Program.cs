using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 3 Вариант

            bool x = true;
            while (x)
            {
                Console.WriteLine("1 Задание");
                Console.WriteLine("2 Задание");
                Console.WriteLine("3 Задание");
                Console.WriteLine("Выход");
                Console.WriteLine();

                int t = int.Parse(Console.ReadLine());

                switch (t)
                {
                    case 1:
                        MinMax.minmax();
                        break;
                    case 2:
                        Nums.nums();
                        break;
                    case 3:
                        Game.game();
                        break;
                    case 4:
                        Console.WriteLine("Выход...");
                        x = false;
                        break;
                    default:
                        Console.WriteLine("Такого пункта нет.");
                        break;
                }
            }

            Console.ReadLine();

        }
    }
}
