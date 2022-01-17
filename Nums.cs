using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Nums
    {
        public static void nums()
        {
            Random rnd = new Random();
            int K = rnd.Next(50, 100);
            int[] M = new int[K];
            int num = 0;
            for (int i = 0; i < K; i++)
            {
                M[i] = rnd.Next(-200, 200);
                if (M[i] > 0 && M[i] < 125)
                num++;
            }
            Console.WriteLine(num);
            Console.WriteLine();
        }
    }
}