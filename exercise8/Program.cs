using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько людей в очереди?");
            uint peoplesСount = Convert.ToUInt32(Console.ReadLine());
            uint waitingTimeInMinutes = 10;
            uint minuteInTheHour = 60;
            uint waitHours = peoplesСount * waitingTimeInMinutes / minuteInTheHour;
            uint waitMinutes = peoplesСount * waitingTimeInMinutes % minuteInTheHour;
            Console.WriteLine($"Вам осталось ждать: {waitHours} часов {waitMinutes} минут.");
            Console.ReadLine();
        }
    }
}
