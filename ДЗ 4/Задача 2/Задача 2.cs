using System;
using System.IO;

namespace Задача_2
{
	/*
		2. Реализуйте задачу 1 в виде статического класса StaticClass;
			а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
			б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
			в)** Добавьте обработку ситуации отсутствия файла на диске.
	*/
	public static class StaticClass
	{
		public static void Main() {
			int[] testArr = RandomIntArr(20);
			Console.WriteLine($"Количество пар с одним делимым тройки: {PairCalc(testArr)}");

			int[] testArrFromFile = ReadArrFromFile("arrFile.txt");
			foreach (int el in testArrFromFile)
            {
				Console.WriteLine(el);
            }
			Console.ReadKey();
		}

		static int[] RandomIntArr(int ArrLength)
        {
			int[] arr = new int[ArrLength];
			Random rnd = new Random();

			for (int i = 0; i < arr.Length; i++)
            {
				arr[i] = rnd.Next(-10000, 10000);
            }
			return arr;
        }
		static int PairCalc(int[] arr)
		{
			int[] MyArray = arr;
			int count = 0;

			for (int i = 0; i < arr.Length-1; i++)
			{
				Console.WriteLine(MyArray[i]);
				if (isPairDivByThree(MyArray, i))
				{
					count++;
				};
			}
			return count;
		}
		/// <summary>
		/// Проверка, есть ли в паре arr[i], arr[i+1] одно и только одно делящяеся на 3.
		/// </summary>
		/// <param name="MyArray">Массив целых чисел</param>
		/// <param name="i">Индекс начального элемента</param>
		/// <returns></returns>
		static bool isPairDivByThree(int[] MyArray, int i)
		{
			return (MyArray[i] % 3 == 0 && MyArray[i + 1] % 3 != 0) || (MyArray[i] % 3 != 0 && MyArray[i + 1] % 3 == 0);
		}

		static int[] ReadArrFromFile(string filename)
		{
			int[] arr = new int[1];
			if (File.Exists(filename))
			{
				string[] ss = File.ReadAllLines(filename);
				arr = new int[ss.Length];
				for (int i = 0; i < ss.Length; i++)
					arr[i] = int.Parse(ss[i]);
			}
			else Console.WriteLine("Искомый файл отсутсвует");
			Console.WriteLine("Искомый файл успешно загружен");
			return arr;
		}

	}
}
