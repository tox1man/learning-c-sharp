using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_1_ДЗ_1_Задача_3
{
    class DistanceCalc
    {
        static void Main()
        {
            Console.Write("Введите координату X1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату X2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            TwoPointsDistance(x1,y1,x2,y2);
            Console.ReadKey();
        }
        static double TwoPointsDistance(int x1, int y1, int x2, int y2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"{result:N2}");
            return result;
        }
    }
}
