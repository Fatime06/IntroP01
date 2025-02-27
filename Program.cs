using System;
//TASK1

//class Calculator
//{
//	static void Main()
//	{
//		int num1 = 5;
//		int num2 = 10;
//		string sign = Console.ReadLine();

//		if (sign == "+")
//		{
//			Console.WriteLine(num1 + num2);
//		}
//		else if (sign == "-")
//		{ 
//			Console.WriteLine(num1 + num2);
//		}
//		else if (sign == "*")
//		{
//			Console.WriteLine(num1 * num2);
//		}
//		else if (sign == "/")
//		{
//			Console.WriteLine(num1 / num2);
//		}
//		else
//		{
//			Console.WriteLine("İşare düzgün daxil edilmeyib!");
//		}

//	}

//}



//TASK2

//class Salary
//{
//	static void Main()
//	{
//		Console.WriteLine("Maaşi daxil edin!");
//		int salary = Convert.ToInt32(Console.ReadLine());
//		Console.WriteLine("Kiraye ödenişini daxil edin!");
//		int rentPayment = Convert.ToInt32(Console.ReadLine());
//		Console.WriteLine("Magaza xerclerini daxil edin!");
//		int storeExpense = Convert.ToInt32(Console.ReadLine());
//		Console.WriteLine("Neqliyyat xeclerini daxil edin!");
//		int transportExpense = Convert.ToInt32(Console.ReadLine());

//		int galiq = salary - (rentPayment + storeExpense + transportExpense);
//		Console.WriteLine($"Galig = {galiq}");


//	}
//}




//TASK3

//class Birthday
//{
//	static void Main()
//	{
//		Console.WriteLine("Yaşınızı daxil edin!");
//		int age = Convert.ToInt32(Console.ReadLine());
//		Console.WriteLine("Dogum gününüze galan ay sayini daxil edin!");
//		int month = Convert.ToInt32(Console.ReadLine());

//		int dayCount = month * 30;
//		Console.WriteLine(dayCount);
//	}
//}



//TASK 4

//class Converter
//{
//	static void Main()
//	{
//		Console.WriteLine("Temperatur vahidini daxil edin (C ve yaF)! ");
//		string sign = Console.ReadLine();

//		Console.WriteLine("Temperaturu daxil edin! ");
//		int temperature = Convert.ToInt32(Console.ReadLine());

//		if (sign == "C")
//		{
//			double fahrenheit = (temperature * 9 / 5) + 32;
//			Console.WriteLine($"{temperature}°C = {fahrenheit}°F");
//		}
//		else if (sign == "F")
//		{
//			double celsius = (temperature - 32) * 5 / 9;
//			Console.WriteLine($"{temperature}°F = {celsius}°C");
//		}
//		else
//		{
//			Console.WriteLine("Yanlış vahid daxil edildi!");
//		}
//	}
//}



//TASK5

class Guess
{
	static void Main()
	{
		int secretNumber = 7;
		int guess;

		Console.WriteLine("1-dən 10-a qədər olan gizli nömrəni təxmin edin!");

		while (true)
		{
			Console.WriteLine("Texmininizi daxil edin!");
			guess = Convert.ToInt32(Console.ReadLine());

			if (guess < secretNumber)
				Console.WriteLine("Texmin gizli saydan asagidir! ");
			else if (guess > secretNumber)
				Console.WriteLine("Texmin gizli saydan yuxaridir!");
			else
			{
				Console.WriteLine("Texmin duzdur!");
				break;
			}
		}
	}
}
