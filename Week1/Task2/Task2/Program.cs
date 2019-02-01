using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		class Student //СОздадим класс
		{
			string name; //Строка имени 
			string id; 	//СТрока моей айдишки
			int year = 1; //переменная для хранения года (Целого года)

			public Student(string name, string id){	 //cКонструктор с двумя переменными (Именем и айдишкой)
				this.name = name; //Присваиваем строке Имя, которое отправляем в функции Main
				this.id = id; 	//Тут тоже самое
			}

			public void print() //Метод для принта Имени, айдишки ,года 
			{
				Console.WriteLine("Name of student: {0}", name); //Выводим имя
				Console.WriteLine("Id of student: " + id); //Выводим айди
				Console.WriteLine("Year of study: " + year);	//Выводим год
			}

			public void incr() //Метод для инкремента года
			{
				year++;
				Console.WriteLine("Year of student increased by one, now is {0}", year); //Вывод инкрементированного года
			}
		}
		static void Main(string[] args)				//Галвная функция Main
		{					
			Student s1 = new Student("Nam Nikita", "18BD110887"); //СОздаем нвоыйй обьект класса Student и закидываем туда значения
			s1.print(); // Вызываем метод принта класса Студент
			s1.incr(); //	Вызываем метод инкремента Года и его вывода
		}
	}
}