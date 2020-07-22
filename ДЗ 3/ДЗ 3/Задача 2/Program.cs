using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            string text = "Сумма нечетных положительных чисел из ряда ";

            Console.WriteLine("Введите целые числа. 0 для выхода");

            int a = int.Parse(Console.ReadLine());
            if (a > 0 && a % 2 != 0) sum+=a;
            count++;

            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a > 0 && a % 2 != 0) sum+=a;
                text += a;
                text += " ";
            }
            Console.WriteLine(text + $"равна {sum}");
        }
    }
}
