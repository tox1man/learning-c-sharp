using System;
using System.Linq;
using System.IO;
using System.Data.Common;

namespace Задача_3
{
    /*    
     3.
        а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от 
        начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными 
        знаками у всех элементов массива(старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, 
        возвращающее количество максимальных элементов.

        б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки

        е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
    */
        class CoolArray
        {
            private int[] a;
            Random rnd = new Random();

        /// <summary>
        /// Создает массив заданной длины от минимального значения с заданным шагом
        /// </summary>
        /// <param name="len">Длина массива</param>
        /// <param name="minValue">Миним. знач.</param>
        /// <param name="step">Шаг</param>
            public CoolArray(int len, int minValue, int step)
            {
                a = new int[len];
                a[0] = minValue;
                for (int i = 1; i < len; i++)
                {
                    a[i] = a[i - 1] + step;
                }
            }         
        
            public CoolArray(int len)
            {
                a = new int[len];
            }
            
            public int Sum()
            {
                int sum = 0;
                foreach(int el in a)
                {
                    sum += el;
                }
                return sum;
            }

        public CoolArray Inverse()
        {
            CoolArray InversedArr = new CoolArray(a.Length);
            for (int i = 0; i < a.Length; i++)
            {
                InversedArr[i] = -a[i];
            }
            return InversedArr;
        }

        public CoolArray Multi(int factor)
        {
            CoolArray MultArr = new CoolArray(a.Length);
            for (int i = 0; i < a.Length; i++)
            {
                MultArr[i] = a[i] * factor;
            }
            return MultArr;
        }

        /// <summary>
        /// Загрежает массив из файла с указанным именем
        /// </summary>
        /// <param name="filename">Имя файла</param>
        public CoolArray(string filename)
            {
                //Если файл существует
                if (File.Exists(filename))
                {
                    //Считываем все строки в файл 
                    string[] ss = File.ReadAllLines(filename);
                    a = new int[ss.Length];
                    //Переводим данные из строкового формата в числовой
                    for (int i = 0; i < ss.Length; i++)
                        a[i] = int.Parse(ss[i]);
                }
                else Console.WriteLine("Error load file");
            }


        public int Max
        {
            get
            {
                //  Находим максимальный элемент
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }


        public int MaxCount
        {
            get
            {
                int max = this.Max;
                int mCount = 0;
                foreach (int el in a)
                {
                    if (el == max)
                    {
                        mCount++;
                    }
                }
                return mCount;
            }
        }

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        public void Print()
            {
                foreach (int el in a)
                    Console.Write("{0,4}", el);
                    Console.WriteLine();
        }
        }


        class Program
        {
            static void Main(string[] args)
            {
                CoolArray array = new CoolArray(10, 2, 2);
                array.Print();
                Console.WriteLine(array.Sum());
                CoolArray invArr = array.Inverse();
                invArr.Print();
                CoolArray multArr = invArr.Multi(10);
                multArr.Print();
                Console.WriteLine("Максимальный элемент: " + array.Max);
                Console.WriteLine("Количество максимальных элементов: " + array.MaxCount);
                Console.ReadKey();
            }
        }
    }

