﻿Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int x1=num%100;
int x2=x1/10;
Console.WriteLine("вторая цифра числа"+x2);