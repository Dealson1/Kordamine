using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class MinMax
    {
        public static void minmax()
        {
            var mas = new decimal[10];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите {0} число : ", i + 1);
                mas[i] = Convert.ToDecimal(Console.ReadLine());
            }

            var max = mas[0];
            var min = mas[0];

            for (int i = 1; i < 5; i++)
            {
                if (mas[i] < min) min = mas[i];
                if (mas[i] > max) max = mas[i];
            }

            Console.WriteLine("Разность между максимальным и минимальным числом = {0}", max - min);
            Console.WriteLine();
        }
    }
}
