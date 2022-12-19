// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Отрицательные числа должны нормально работать.

// -645 -> 5
// 645 -> 5
// 78 -> третьей цифры нет
// 3261279 -> 6

Console.Write("Введите 3-х значное число: ");
string number = Console.ReadLine()!;
if (number[0] == '-')
{
    if (number.Length >= 4)
    {
        Console.WriteLine(number[3]);
    }

    else
    {
        Console.Write("Введите 3-х значное число!");
    }
}
else
{
    if (number.Length >= 3)
    {
        Console.WriteLine(number[2]);
    }

    else
    {
        Console.Write("Введите 3-х значное число!");
    }
}