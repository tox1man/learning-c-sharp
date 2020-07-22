using System;

namespace Урок_1_ДЗ_1_задача_2
{
    class BodyMassIndex
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свой рост в метрах, отделяя запятой: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой вес в килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double BodyMassIndex = (weight / (height * height));
            Console.WriteLine($"Индекс массы вашего тела: {BodyMassIndex:N2}");
            Console.ReadKey();
        }
    }
}
