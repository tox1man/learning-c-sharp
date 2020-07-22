using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_1_ДЗ_1_задача_1
{
    class Profile
    {
        static void Main(string[] args)
        {
            Console.Write("Меня зовут: ");
            string name = Console.ReadLine();
            Console.Write("По фамилии: ");
            string surename = Console.ReadLine();
            Console.Write("Мой рост в сантимертах: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Мой вес в килограммах: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вас зовут " + name + " " + surename + ", ваш рост " + height + " сантиметров, вес " + weight + " килограм."); //a
            Console.WriteLine($"Вас зовут {name} {surename}, ваш рост {height} сантиметров, вес {weight} килограм."); //б
            Console.WriteLine("Вас зовут {0} {1}, ваш рост {2} сантиметров, вес {3} килограм.", name, surename, height, weight); //в
            Console.ReadKey();
        }
    }
}
