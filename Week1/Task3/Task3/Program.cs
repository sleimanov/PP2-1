using System;

namespace project1
{
	class MainClass 
	{ 
		public static void write(int[] a, int n, string[] s){  		//Вывод массива (Вывод каждого элемента два раза)
			int j = 0;			//Для считывания элемента СТРОКИ
			for (int i = 0; i < 2*n; i+=2) {

				a [i] = int.Parse (s [j]);				//a[i] && a[i+1] с одного s[j], Для повторения одного символа СТРОКИ для двуъ элементов массива
				a [i+1]= int.Parse (s [j]);
				j++;
			}
			for ( int i = 0; i < 2*n; i++) {
				Console.Write (a [i] + " ");			// Вывод обычный. 2*n потому что в 2 раза больше элементов

			}
		}
		public static void Main (string[] args)				//Функция Мэйн
		{
			int n;			//Количество символов
			string[] s = new string[256];				//Строка с символами
			int[] a = new int[100000];				//Массив для символов
			n = Convert.ToInt32 (Console.ReadLine ());				//Считываем количество символов
			s = Console.ReadLine().Split();				//Считываем числа ждя массива
			for (int i = 0; i < 2*n+1; i++) {				//Заполнение массива нулями 
				a [i] = 0;
			}
			write (a, n, s);			//Вызов функци вывода
		
		}

	}
}