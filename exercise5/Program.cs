using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Петров";
            string lastName = "Иван";
            string buffer = name;
            name = lastName;
            lastName = buffer;
            Console.WriteLine($"Имя: {name}\nФамилия: {lastName}");
        }
    }
}
