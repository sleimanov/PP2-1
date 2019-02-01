using System;

namespace project1
{
	class MainClass 
	{ 
		public static bool Simple(int n){
			if (n == 1)
				return false;
			for (int i = 2; i <= Math.Sqrt (n); i++) {
				if (n % i == 0)
					return false;
			}
			return true;
		}
		public static void Main (string[] args) 		//Функция основная
		{
			int n;
			string[] s = new string[1000];			//Инициалзиация строки дял считывания
			int[] a = new int[100000];			//Инициализация для чисел, которые будут проверяться
			int[] b = new int[100000];	
			n = Convert.ToInt32 (Console.ReadLine ());		//Считываем N (Колво чисел)
			s = Console.ReadLine().Split();				

			for (int i = 0; i < n; i++) {
				a[i] = int.Parse (s[i]);				//"Парс" ЦЕЛЫХ чисел и закидывание в массив
			}
			int count = 0;
			for (int i = 0; i < n; i++) {
				if (Simple (a [i]) == true) {//Отправляю в функцию Simple и проверяю число на простоту
					b [count] = a [i];
					count++;
				}
			}
			Console.WriteLine (count);
			for (int i = 0; i < count; i++) {
				Console.Write (b[i]+" ");			//Вывод
			}
		}

	}
}