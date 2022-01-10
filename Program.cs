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
            Console.WriteLine("1 - Подсчет символов в строке./ 2 - 2 Задание/ 3 - 3 Задание/ 4 - Выход");
            bool x = true;
            while (x)
            {
                int t = int.Parse(Console.ReadLine());

                switch (t)
                {
                    case 1:
                        SubClass.CharInText();
                        break;
                    default:
                        Console.WriteLine("Такого пункта нет.");
                        break;
                }
            }
        }
    }
}
