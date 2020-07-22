using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


/*1. Написать метод, возвращающий минимальное из трех чисел.
2. Написать метод подсчета количества цифр числа.
3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить 
ввод пароля тремя попытками.
5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени 
выполнения программы, используя структуру DateTime.
7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
Достаточно решить 4 задачи. Разбивайте программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы делайте в одном решении.
 */

namespace ДЗ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuScreen();
        }

        private static void MenuScreen()
        {
            string MenuText = "Меню:\n" +
                            "1.Метод, возвращающий минимальное из трех чисел.\n" +
                            "2.Метод подсчета количества цифр числа.\n" +
                            "3.С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.\n" +
                            "4.Метод проверки логина и пароля.\n" +
                            "5.Расчет массы тела и идеального веса.\n" +
                            "6.Подсчет 'хороших' чисел.\n";

            Console.WriteLine(MenuText);
            int TextInput = Convert.ToInt32(Console.ReadLine());
            switch (TextInput)
            {
                case 1: ThreeIntMin(); break;
                case 2: NumberLengthCalculator(); break;
                case 3: PosOddSum(); break;
                case 4: Login(); break;
                case 5: IdealWeightCalc(); break;
                case 6: GoodNumberFinder(); break;
                default: MenuScreen(); break;
            }
        }

        /// <summary>
        /// Подсчитывает кол-во "хороших" чисел в заданном интервале.
        /// </summary>
        /// <param name="FindRange"></param>
        private static void GoodNumberFinder()
        {
            Console.Write("Сколько чисел проанализировать? ");
            long FindRange = Convert.ToInt64(Console.ReadLine());
            long GoodNumberCount = 0;
            var Time = new Stopwatch();
            Time.Start();
            for (long i = 1; i < FindRange; i++)
            {
                if (isGood(i))
                {
                    GoodNumberCount++;
                }
                //Console.Clear();
                double PercentComplete = (double)i / (double)FindRange * 100;
                Console.WriteLine($"Выполнено {PercentComplete:N1} %");
            }
            Time.Stop();
            Console.WriteLine($"Из {FindRange} чисел оказалось {GoodNumberCount} хороших.");
            Console.WriteLine($"Времени прошло: {(double)Time.ElapsedMilliseconds/1000:N3} сек.");
            ShowMenu();
        }
        /// <summary>
        /// Возвращает хорошее ли число передано через аргумент
        /// </summary>
        /// <param name="InputNum">Число типа long</param>
        /// <returns>Bool</returns>
        static bool isGood(long InputNum)
        {
            long Sum = 0;
            long Temp = InputNum;
            while (Temp > 0)
            {
                Sum += Temp % 10;
                //Console.WriteLine($"Sum: {Sum}");
                Temp /= 10;
                //Console.WriteLine($"Num: {Temp}");
            }
            //Console.WriteLine(InputNum % Sum == 0);
            return InputNum % Sum == 0;
        }

        /// <summary>
        /// Расчитывает ваш индекс массы тела и дает совет о похудении\набору веса
        /// </summary>
        private static void IdealWeightCalc()
        {
            Console.Write("Введите свой рост в сантиметрах: ");
            double Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите свой вес в килограммах: ");
            double Weight = Convert.ToDouble(Console.ReadLine());
            double BodyMassIndex = (Weight / ((Height / 100) * (Height / 100)));
            double IdealWeight = 20 * ((Height / 100) * (Height / 100));

            Console.WriteLine($"Индекс массы вашего тела: {BodyMassIndex:N2}");
            if (IdealWeight > Weight)
            {
                Console.WriteLine($"До идеального веса вам нужно набрать {IdealWeight - Weight:N0} кг.");
            }
            else
            {
                Console.WriteLine($"До идеального веса вам нужно сбросить {Weight - IdealWeight:N0} кг.");
            }
            ShowMenu();
        }

        /// <summary>
        /// Программа проверки логина и пароля
        /// </summary>
        private static void Login()
        {
            string CorrectLogin = "root";
            string CorrectPwd = "GeekBrains";
            string InputLogin = String.Empty;
            string InputPwd = String.Empty;
            sbyte TryCount = 0;

            do
            {
                Console.WriteLine("Для входа введите логин и пароль.");
                Console.Write("Логин: ");
                InputLogin = Console.ReadLine();

                Console.Write("Пароль: ");
                InputPwd = Console.ReadLine();
                if (InputLogin == CorrectLogin && InputPwd == CorrectPwd)
                {
                    Console.WriteLine("Добро пожаловать.");
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильный логин или пароль. Попробуйте еще раз.");
                    TryCount++;
                    Console.WriteLine($"Осталось {3-TryCount} попытки");
                    continue;
                }
            } while (TryCount < 3);

            if(TryCount == 3)
            {
                Console.WriteLine("Ваши попытки исчерпаны. Попробуйте позже.");
            }
            ShowMenu();
        }

        /// <summary>
        /// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        /// </summary>
        private static void PosOddSum()
        {
            int InputValue;
            int result = 0;
            do
            {
                Console.Write("Введите число для расчета (0 для выхода): ");
                InputValue = Convert.ToInt32(Console.ReadLine());
                if (InputValue % 2 != 0 && InputValue > 0)
                {
                    result += InputValue;
                }
            } while (InputValue != 0);

            Console.WriteLine($"Сумма положительных нечетных чисел равна {result}.");
            ShowMenu();
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Нажмите любую клавишу для возврата в меню");
            Console.ReadKey();
            Console.Clear();
            string MenuText = "Меню:\n" +
                            "1.Метод, возвращающий минимальное из трех чисел.\n" +
                            "2.Метод подсчета количества цифр числа.\n" +
                            "3.С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.\n" +
                            "4.Метод проверки логина и пароля.\n" +
                            "5.Расчет массы тела и идеального веса.\n" +
                            "6.Подсчет 'хороших' чисел.\n";

            Console.WriteLine(MenuText);
            int TextInput = Convert.ToInt32(Console.ReadLine());
            switch (TextInput)
            {
                case 1: ThreeIntMin(); break;
                case 2: NumberLengthCalculator(); break;
                case 3: PosOddSum(); break;
                case 4: Login(); break;
                case 5: IdealWeightCalc(); break;
                case 6: GoodNumberFinder(); break;
                default: MenuScreen(); break;
            }
        }

        /// <summary>
        /// Метод подсчета количества цифр числа
        /// </summary>
        private static void NumberLengthCalculator()
        {
            Console.Write("Введите число для подсчета количества цифр: ");
            Int64 InputValue = Convert.ToInt64(Console.ReadLine());
            Int64 InputValueLength = (Int64)Math.Floor(Math.Log10(InputValue)) + 1;

            Console.WriteLine($"Длина числа {InputValue} равна {InputValueLength}");
            ShowMenu();
        }

        /// <summary>
        /// Метод, возвращающий минимальное из трех чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третье число</param>
        private static void ThreeIntMin()
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int min = a;
            if (a > b)
            {
                min = b;
            }
            else if (b > c)
            {
                min = c;
            }

            Console.WriteLine($"Минимальное число: {min}");
            ShowMenu();
        }
    }
}