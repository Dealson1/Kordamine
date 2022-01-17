using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Game
    {
        public static void game()
        {
            Console.WriteLine("Сколько игроков добавить?");
            int playerscount = int.Parse(Console.ReadLine());
            var players = Enumerable.Range(1, playerscount).ToList();
            Console.WriteLine("Кого казнить?");
            int k = int.Parse(Console.ReadLine());
            int Num = 0;
            Console.WriteLine(string.Join(" ", players));
            while (players.Count > 1)
            {
                Num = (Num + k) % players.Count;
                players.RemoveAt(Num);
                Console.WriteLine(string.Join(" ", players));
                Console.WriteLine();
            }
        }
    }
}
