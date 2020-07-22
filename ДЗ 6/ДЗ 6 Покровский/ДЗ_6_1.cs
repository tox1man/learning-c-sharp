using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_6_Покровский
{

    /*
     * Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
     * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
    */

    public delegate double Fun(double x);
    public delegate double Fun2(double x, double a);
    class ДЗ_6_1
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1.5;
            }
            Console.WriteLine("---------------------");
        }
        public static void Table(Fun2 F, double x, double a, double b)
        {
            double j = a;
            double i = x;
            Console.WriteLine("----- X ------- A ------- Y -----");
            for (i = x; i <= b; i += 1.5)
            {
                for(j = a; j <= b; j += 1)
                {
                    Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", i, j, F(i, j));
                }
                j = 0;
            }
            Console.WriteLine("---------------------");
        }
        public static double Cube(double x)
        {
            return x * x * x;
        }     
        public static double SqrWithParam(double x, double a)
        {
            return a * x * x;
        }   
        public static double SinWithParam(double x, double a)
        {
            return a * Math.Sin(x);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Таблица функции MyFunc:");
            Table(Cube, -2, 10);   
            Console.WriteLine("Таблица функции MyFunc с параметром а:");
            Table(SqrWithParam, -2, -5, 10);
            Console.WriteLine("Таблица функции Sin(x):");
            Table(Math.Sin, -3, 3);
            Console.WriteLine("Таблица функции a*Sin(x):");
            Table(SinWithParam, -3, -3, 3);
            Console.ReadKey();
        }

    }
}

