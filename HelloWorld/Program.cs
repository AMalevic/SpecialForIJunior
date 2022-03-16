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
                string name = AskName();
                uint age = AskAge();
                string zodiacSign = AskZodiacSign();

                printResult(name, age, zodiacSign);
                // Как лучше назвать функцию?
            } while (isRepeat());
        }

        static bool isRepeat()
        {
            Console.WriteLine("Еще разок?\n(для повтора нажмите любую клавишу. Если хотите завершить, то нажмите ESC");
            ConsoleKey input = Console.ReadKey().Key;
            if (ConsoleKey.Escape != input)
            {
                Console.Clear();
                return true;
            }
            Console.Clear();
            return false;
        }

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
            const uint defaultAge = 25;
            uint age = defaultAge;
            

            Console.WriteLine("Сколько вам лет?");
            string input = Console.ReadLine();
            bool isCorrectInput = uint.TryParse(input, out uint number);
            if (isCorrectInput)
            {
                age = number;
            }
            else
            {
                Console.WriteLine("Вы сломали пространство и время! \n Или мы не можем понять ваш ответ!");
                Console.WriteLine("Мы думаем, что вам 25 лет!");
                Console.ReadKey();
            }
            Console.Clear();
            return age;

        }

        static string AskZodiacSign()
        {
            string zodiacSign;
            Console.WriteLine("Кто вы по знаку зодиака?");
            zodiacSign = Console.ReadLine();
            if (zodiacSign == "") 
            {
                Console.WriteLine("Вы все сломали! Значит вы ОВЕН!");
                Console.ReadKey();
                // Можно ли считать ЭТО магическим значением?
                zodiacSign = "Овен";
            }
            Console.Clear();
            
            return zodiacSign;
        }

        static void printResult(string name, uint age, string zodiacSign)
        {
            const uint impossibleAge = 1000;
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


