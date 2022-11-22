//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if (b > a)
{
    Console.Write("Максимальное число: ");
    Console.Write(b);
}
else
{
    Console.Write("Максимальное число: ",a);
    Console.Write(a);
}
// Console.Write($"{NegN} ");
//string a = Console.ReadLine();
//int N = int.Parse(a);
//int NegN = - N;