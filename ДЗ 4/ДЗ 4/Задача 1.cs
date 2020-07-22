﻿using System;

namespace ДЗ_4
{

	/*
	1.Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  
	Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
	В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
	2. Реализуйте задачу 1 в виде статического класса StaticClass;
		а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
		б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
		в)** Добавьте обработку ситуации отсутствия файла на диске.
	3.
		а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения 
	с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех 
	элементов массива(старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее 
	количество максимальных элементов.
		б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
		е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)

	4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account, содержащую Login и Password.
	5. 
	   *а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.Создать методы, 
	   *которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, 
	   *возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
	   ** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
	   ** в) Обработать возможные исключительные ситуации при работе с файлами.*/


	class Program
	{

		static void Main(string[] args)
		{

			//Задание 1:
			int[] MyArray = new int[20];
			Random rnd = new Random();
			int count = 0;

			Console.WriteLine("Решение 1. Все элементы: ");
			for (int i = 0; i < MyArray.Length; i++)
			{
				MyArray[i] = rnd.Next(-10000, 10000);
				Console.WriteLine(MyArray[i]);

				if (i < MyArray.Length - 1)
				{
					if ((MyArray[i] % 3 == 0 && MyArray[i + 1] % 3 != 0) || (MyArray[i] % 3 != 0 && MyArray[i + 1] % 3 == 0)) //XOR
					{
						count++;
					}
				}
			}
			Console.WriteLine($"Пар, с одним делимым тройки: {count}");
			Console.ReadKey();
		}


	}
}