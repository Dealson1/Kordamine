using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class SubClass
    {
        public static void CharInText()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            Console.WriteLine("Введите символ процент которого хотите найти:");
            char sym = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int len = text.Length;
            char[] list = text.ToCharArray();
            int count = 0; /* Кол-во символов.*/
            for (int i = 0; i < len; i++)
            {
                if (list[i] == sym)
                {
                    count++;
                }
            }
            double doublelen = Convert.ToDouble(len);
            double doublecount = Convert.ToDouble(count);
            double result = (doublecount / doublelen) * 100;
            Console.WriteLine("Процент вхождения символа {0} равен {1}%", sym, result);

            Console.ReadKey();
        }
    }
}
