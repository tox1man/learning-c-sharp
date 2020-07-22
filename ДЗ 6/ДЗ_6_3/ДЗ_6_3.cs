using System;
using System.IO;
using System.Collections.Generic;

/*Переделать программу Пример использования коллекций для решения следующих задач:
    а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
    в) отсортировать список по возрасту студента;
    г) *отсортировать список по курсу и возрасту студента;
*/

namespace ДЗ_6_3
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }
    }
    class ДЗ_6_3
    {
        static int CompareByName(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров по имени
        {

            return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
        }        
        static int CompareByAge(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров по возрасту
        {

            return st1.age.CompareTo(st2.age);          // Сравниваем две строки
        }        
        static int CompareByCourse(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров по курсу
        {

            return st1.course.CompareTo(st2.course);          // Сравниваем две строки
        }        
        //static int CompareByCourseAndAge(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров по курсу
        //{

        //    if (st1.course.CompareTo(st2.course) > 0)
        //    {
        //        st1.age.CompareTo(st2.age)
        //    }
        //}
        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            int[,] Courses18To20 = new int[3, 6];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Courses18To20[i,j] = 0;
                }
            }
            
            List<Student> list = new List<Student>();                             // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_4.csv");
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                // Добавляем в список новый экземпляр класса Student
                list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                // Одновременно подсчитываем количество бакалавров и магистров
                if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20) { 
                    Courses18To20[int.Parse(s[5])-18, int.Parse(s[6])-1]++;
                }
            }
            sr.Close();
            //list.Sort(new Comparison<Student>(CompareByName)); // сортировка по Имени
            list.Sort(new Comparison<Student>(CompareByAge)); // сортировка по Возрасту
            list.Sort(new Comparison<Student>(CompareByCourse)); // сортировка по Курсу

            //TODO
            //list.Sort(new Comparison<Student>(CompareByCourseAndAge)); // сортировка по Курсу и Возрасту

            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            Console.WriteLine("Учащихся 5-6 курсов:{0}", bakalavr + magistr);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine($"Кол-во учащихся {18+i} лет на {j+1} курсе: {Courses18To20[i, j]}");
                }
            }
            

            foreach (var v in list)
            {

                //Console.WriteLine(v.firstName);
                //Console.WriteLine(v.age);
            }
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}
