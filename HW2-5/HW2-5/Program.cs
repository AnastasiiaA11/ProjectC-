﻿// See https://aka.ms/new-console-template for more information



	Console.WriteLine("Введите двузначное число.");
	int number = Convert.ToInt32(Console.ReadLine());
	int dozens = number / 10; //десятки
	int units = number % 10; // единицы
	string firstWord = "двадцать", secondWord = "один";

	if (dozens >= 2 && dozens < 10)
	{
		switch (dozens) //Конструкция switch/case оценивает некоторое выражение и сравнивает его значение с набором значений. И при совпадении значений выполняет определенный код.
	{
			case 2: firstWord = "двадцать"; break;//Оператор break завершает выполнение ближайшего внешнего break
		    case 3: firstWord = "тридцать"; break;
			case 4: firstWord = "сорок"; break;
			case 5: firstWord = "пятьдесят"; break;
			case 6: firstWord = "шестьдесят"; break;
			case 7: firstWord = "семьдесят"; break;
			case 8: firstWord = "восемьдесят"; break;
			case 9: firstWord = "девяносто"; break;
		}
		switch (units)
		{
			case 0: secondWord = ""; break;
			case 1: secondWord = "один"; break;
			case 2: secondWord = "два"; break;
			case 3: secondWord = "три"; break;
			case 4: secondWord = "четыре"; break;
			case 5: secondWord = "пять"; break;
			case 6: secondWord = "шесть"; break;
			case 7: secondWord = "семь"; break;
			case 8: secondWord = "восемь"; break;
			case 9: secondWord = "девять"; break;
		}
		Console.WriteLine(number + " - " + firstWord + " " + secondWord);
	}
	else if (dozens == 1)
	{
		switch (number)
		{
			case 10: firstWord = "десять"; break;
			case 11: firstWord = "одиннадцать"; break;
			case 12: firstWord = "двенадцать"; break;
			case 13: firstWord = "тринадцать"; break;
			case 14: firstWord = "четырнадцать"; break;
			case 15: firstWord = "пятнадцать"; break;
			case 16: firstWord = "шестнадцать"; break;
			case 17: firstWord = "семнадцать"; break;
			case 18: firstWord = "восемнадцать"; break;
			case 19: firstWord = "девятнадцать"; break;
		}
		Console.WriteLine(number + " - " + firstWord);
	}
	else Console.WriteLine("Введите двузначное число корректно");

	
