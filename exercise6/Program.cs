using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            uint artСounter = 52;
            uint rowLimit = 3;
            uint fullLineСounter;
            uint remainder;

            fullLineСounter = artСounter / rowLimit;
            remainder = artСounter % rowLimit;
            Console.WriteLine($"Заполненых рядов: {fullLineСounter}\n Излишек: {remainder}");
            Console.ReadKey();
        }
    }
}
