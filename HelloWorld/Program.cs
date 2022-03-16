using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 2.
            //ConsoleKeyInfo input = Console.ReadKey();
            //string text = "Съешь еще этих мягких французских булок..."; 
            //uint life = 100;
            //bool isAlive = true;
            //float damageFist = 10.5f;
            //char symbol = 'a';
            //int laps = 1;
            //double xPosition = 233214.4324;
            //ulong gold = 18446744073709551615;
            //ushort experience = 41214;

            //Задание 4.

            Run();
        }

        static void Run()
        {
            string name = AskName();
            uint age = AskAge();
            string zodiacSign = AskZodiacSign();

            SayHello(name, age, zodiacSign);

        }

        // Задел для проверки ввода. Можно сделать первую букву большой.
        static String AskName()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("Вы ничего не написали! \n Тогда я вас назову: Виталий!");
                Console.ReadKey();
                name = "Виталий";
            }
            Console.Clear();
            return name;

        }
        static uint AskAge()
        {
            uint age = 25;
            Console.WriteLine("Сколько вам лет?");
            try
            {
                age = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы сломали пространство и время! \n Или мы не можем понять ваш ответ!");
                Console.WriteLine("Мы думаем, что вам 25 лет!");
                Console.ReadKey();
                age = 25;
            }
            Console.Clear();
            return age;

        }

        // Ничего не придумал. Может потом дополню) 
        static string AskZodiacSign()
        {
            string zodiacSign;
            Console.WriteLine("Кто вы по знаку зодиака?");
            try {
                zodiacSign = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Вы все сломали! Значит в ОВЕН!");
                zodiacSign = "Овен";
            }

            Console.Clear();
            
            return zodiacSign;
        }

        static void SayHello(string name, uint age, string zodiacSign)
        {
            Console.Clear();
            Console.WriteLine("Добрый день, " + name);
            Console.WriteLine($"Вам {age} лет!");
            if (age > 1000)
            {
                Console.WriteLine("Мы всегда рады пришельцам!)");
            }
            Console.WriteLine("Ваш зна зодиака: " + zodiacSign);

            Console.WriteLine("Еще разок?\n(для повтора нажмите любую клавишу. Если хотите завершить, то нажмите ESC");
            ConsoleKey input = Console.ReadKey().Key;
            if (ConsoleKey.Escape != input)
            {
                Run();
            }
        }
    }
}


