using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


/*
 Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 

а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. 
Использовать массив (или список) делегатов, в котором хранятся различные функции.

б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out). 
 */
namespace ДЗ_6_2
{
    delegate double MyFunc(double x);
    class Program
    {
        public static List<MyFunc> FunctionArray = new List<MyFunc>(0);
        public static void AddFunction(MyFunc F)
        {
            FunctionArray.Add(F);
            return;
        }
        public static double SomeFunc1(double x)
        {
            return x * x - 50 * x + 10;
        }        
        public static double SomeFunc2(double x)
        {
            return x + x * x;
        }
        public static void SaveFunc(MyFunc F, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double minOut)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            double[] ResultArray = new double[(fs.Length / sizeof(double))];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                ResultArray[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            minOut = min;
            return ResultArray;
        }

        public static void PrintArray(double[] arr)
        {
            string ResultString = String.Empty;
            foreach(int i in arr)
            {
                ResultString += $"{i:N3}  |";
            }
            Console.WriteLine(ResultString);
        }
        public static void Menu()
        {
            string MenuText = "Выберите функцию для нахождения минимума:\n" +
                "1. x * x - 50 * x + 10\n" +
                "2. x + x * x\n" +
                "3. 0.1 * x^3 + 2 * x^2 - 0.4 * x\n" +
                "4. x^3 + 3/x\n" +
                "5. sin(cos(x))\n" +
                "6. Очистить.";
            Console.WriteLine(MenuText);
            double result;
            switch (Convert.ToInt32(Console.ReadLine())) {
                case 1:
                        SaveFunc(FunctionArray[0], "SomeFunc1.bin", GetStart(), GetEnd(), GetStep());
                        PrintArray(Load("SomeFunc1.bin", out result));
                        Console.WriteLine($"Результат: {result}");
                        Menu();
                        return;
                case 2: SaveFunc(FunctionArray[1], "SomeFunc2.bin", GetStart(), GetEnd(), GetStep());
                        PrintArray(Load("SomeFunc2.bin", out result));
                        Console.WriteLine($"Результат: {result}");
                        Menu(); 
                        return;
                case 3: SaveFunc(FunctionArray[2], "SomeFunc3.bin", GetStart(), GetEnd(), GetStep()); 
                        PrintArray(Load("SomeFunc3.bin", out result));
                        Console.WriteLine($"Результат: {result}");
                        Menu(); 
                        return;
                case 4: SaveFunc(FunctionArray[3], "SomeFunc4.bin", GetStart(), GetEnd(), GetStep());
                        PrintArray(Load("SomeFunc4.bin", out result));
                        Console.WriteLine($"Результат: {result}");
                        Menu(); 
                        return;
                case 5: SaveFunc(FunctionArray[4], "SomeFunc5.bin", GetStart(), GetEnd(), GetStep()); 
                        PrintArray(Load("SomeFunc5.bin", out result));
                        Console.WriteLine($"Результат: {result}");
                        Menu(); 
                        return;
                case 6: Console.Clear(); 
                        Menu(); 
                        return;
            }
        }

        private static double GetStep()
        {
            double step;
            Console.Write("Введите шаг (разделяя запятой): ");
            step = Convert.ToDouble(Console.ReadLine());
            return step;
        }

        private static int GetEnd()
        {
            int end;
            Console.Write("Введите верхнюю границу интервала: ");
            end = Convert.ToInt32(Console.ReadLine());
            return end;
        }

        private static int GetStart()
        {
            int start;
            Console.Write("Введите нижнюю границу интервала: ");
            start = Convert.ToInt32(Console.ReadLine());
            return start;
        }

        static void Main(string[] args)
        {
            AddFunction(SomeFunc1);
            
            AddFunction(SomeFunc2);

            AddFunction(delegate (double x) { return 0.1 * (x * x * x) + 2 * (x * x) - 0.4 * x; });

            AddFunction(delegate (double x) { return Math.Pow(x, 3) + 3 / x; });
            
            AddFunction(delegate (double x) { return Math.Sin(Math.Cos(x)); });      

            Menu();

            Console.ReadKey();
        }
    }
}
