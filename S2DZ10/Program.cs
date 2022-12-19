// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите 3-х значное число: ");
int number = int.Parse(Console.ReadLine()!);
if ((number >= 100) && (number < 1000))
{
    int firstD = number % 100;
    int secondD = firstD / 10;
    Console.Write(secondD);
}
else
{
    Console.Write("Введите 3-х значное число!");
}