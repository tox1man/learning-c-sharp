using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок1_ДЗ_1_Задача_4
{
    class ValueSwap
    {
        static void Main(string[] args)
        {
            float a = 10.22f;
            float b = 22.10f;
            float temp;

            Console.WriteLine($"Значение а = {a}, значение b = {b}.");
            Console.WriteLine("Меняем значения");

            //swap
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Новое значение а = {a}, новое значение b = {b}.");
            Console.ReadKey();
        }
    }
}
