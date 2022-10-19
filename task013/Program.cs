﻿// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    while(num > 999)
    {
    num = num / 10;
    }
    int digit3 = num % 10;
    Console.WriteLine($"третья цифра: {digit3}");
}
else
{
    Console.WriteLine("нет третьей цифры");
}