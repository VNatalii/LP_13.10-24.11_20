﻿

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (num > 0)
{
    num = num / 10;
    count++;
}

Console.WriteLine($"Количество цифр в числе равно {count}");


