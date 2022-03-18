using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стартовое значение золота: ");
            uint gold = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Введите цену для одной еденицы кристалла: ");
            uint crystalPrice = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Сколько кристалов купить?\nЦена одного кристала: {crystalPrice} золота.\nУ вас есть: {gold} золота.");
            uint сrystalsToBuy = Convert.ToUInt32(Console.ReadLine());
            uint crystals = 0;

            if (gold- сrystalsToBuy * crystalPrice >= 0)
            {
                gold -= сrystalsToBuy * crystalPrice;
                crystals += сrystalsToBuy;
                Console.WriteLine($"Вы смогли купить {crystals} кристаллов и у вас осталось {gold} золота!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("У вас недостаточно золота для покупки!");
                Console.ReadKey();
            }
        }
    }
}
