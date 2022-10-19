// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num > 7)
{
    Console.WriteLine("не день недели");
}
else if (num == 6 || num == 7)
{
    Console.WriteLine("выходной");
}
else 
{
    Console.WriteLine("не выходной");
}