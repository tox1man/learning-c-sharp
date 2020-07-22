using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_3
{
    class Complex
    {
        double im;
        double re;
        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double re, double im)
        {
            this.im = im;
            this.re = re;
        }
        public Complex Plus(Complex x2)
        {
            Complex result = new Complex();
            result.im = x2.im + im;
            result.re = x2.re + re;
            return result;
        }

        public Complex Minus(Complex x2)
        {
            Complex result = new Complex();
            result.im = im - x2.im;
            result.re = re - x2.re;
            return result;
        }

        public Complex Multiply(Complex x2)
        {
            //z=z1⋅z2=(a1a2−b1b2)+(a1b2+b1a2)i
            Complex result = new Complex();
            result.re = re * x2.re - im * x2.im;
            result.im = re * x2.im + im * x2.re;
            return result;
        }
        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        }   
        public double Re
        {
            get { return re; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) re = value;
            }
        }
        // Специальный метод, который возвращает строковое представление данных.
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            Complex complex1 = new Complex();
            Complex complex2 = new Complex();

            ShowMenu(complex1, complex2);
        }

        public static void ShowMenu(Complex complex1, Complex complex2)
        {
            Complex a = complex1;
            Complex b = complex2;

            Complex result;

            //Console.WriteLine("Нажмите любую клавишу для возврата в меню");
            //Console.ReadKey();
            //Console.Clear();
            string MenuText = "Меню:\n" +
                            "1.Сложение комплексных чисел.\n" +
                            "2.Вычитание комплексных чисел.\n" +
                            "3.Умножение комплексных чисел.\n";

            Console.WriteLine(MenuText);
            int TextInput = Convert.ToInt32(Console.ReadLine());
            switch (TextInput)
            {
                case 1:
                    AskForNumbers(a, b);
                    result = a.Plus(b);
                    ShowResult(a, b, result);
                    break;
                case 2:
                    AskForNumbers(a, b);
                    result = a.Minus(b);
                    ShowResult(a, b, result);
                    break;
                case 3:
                    AskForNumbers(a, b);
                    result = a.Multiply(b);
                    ShowResult(a, b, result);
                    break;
                default: Console.WriteLine("Вы ввели недопустимое значение"); 
                         break;
            }
        }

        private static void ShowResult(Complex a, Complex b, Complex result)
        {
            Console.WriteLine($"a.Re = {a.Re}");
            Console.WriteLine($"a.Im = {a.Im}");
            Console.WriteLine($"b.Re = {b.Re}");
            Console.WriteLine($"b.Im = {b.Im}");
            Console.Write("Результат: ");
            Console.WriteLine(result.ToString());
        }

        private static void AskForNumbers(Complex a, Complex b)
        {
            Console.Write("Введите действительную часть первого числа: ");
            a.Re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого числа: ");
            a.Im = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите действительную часть второго числа: ");
            b.Re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть второго числа: ");
            b.Im = Convert.ToDouble(Console.ReadLine());
        }
    }
}
