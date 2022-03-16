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
            do
            {
                string name = ReadName();
                uint age = ReadAge();
                string zodiacSign = ReadZodiacSign();

                PrintResult(name, age, zodiacSign);
            } 
            while (IsRepeat());
        }

        static bool IsRepeat()
        {
            Console.WriteLine("Еще разок?\n(для повтора нажмите любую клавишу. Если хотите завершить, то нажмите ESC");
            ConsoleKey input = Console.ReadKey().Key;
            Console.Clear();
            return ConsoleKey.Escape != input;
        }

        static String ReadName()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            string defaultName = "Виталий";
            if (name == "")
            {
                Console.WriteLine($"Вы ничего не написали! \n Тогда я вас назову: {defaultName}!");
                Console.ReadKey();
                name = defaultName;
            }
            Console.Clear();
            return name;
        }
        static uint ReadAge()
        {
            uint defaultAge = 25;
            uint age;           

            Console.WriteLine("Сколько вам полных лет?");
            string input = Console.ReadLine();
            bool isCorrectInput = uint.TryParse(input, out uint number);
            if (isCorrectInput)
            {
                age = number;
            }
            else
            {
                Console.WriteLine("Вы сломали пространство и время! \n Или мы не можем понять ваш ответ!");
                Console.WriteLine($"Мы думаем, что вам {defaultAge} лет!");
                age = defaultAge;
                Console.ReadKey();
            }
            Console.Clear();
            return age;
        }

        static string ReadZodiacSign()
        {
            string zodiacSign;
            string defaultZodiacSign = "Овен";
            Console.WriteLine("Кто вы по знаку зодиака?");
            zodiacSign = Console.ReadLine();
            if (zodiacSign == "") 
            {
                Console.WriteLine($"Вы все сломали! Значит вы {defaultZodiacSign}!");
                Console.ReadKey();

                zodiacSign = defaultZodiacSign;
            }
            Console.Clear();
            
            return zodiacSign;
        }

        static void PrintResult(string name, uint age, string zodiacSign)
        {
            uint impossibleAge = 1000;
            Console.Clear();
            Console.WriteLine("Добрый день, " + name);
            Console.WriteLine($"Вам {age} лет!");
            if (age > impossibleAge)
            {
                Console.WriteLine("Мы всегда рады пришельцам!)");
            }
            Console.WriteLine("Ваш зна зодиака: " + zodiacSign);   
        }
    }
}


