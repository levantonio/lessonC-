﻿int numberA = new Random().Next(1, 10); //1 2 3 4 5 6....9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);//new random().Next - генератор случайных чисел в скобках диапазон
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);