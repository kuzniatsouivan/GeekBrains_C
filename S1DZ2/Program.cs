// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
string imput1 = Console.ReadLine()!;
int number1 = int.Parse(imput1);

Console.Write("Введите второе число: ");
string imput2 = Console.ReadLine()!;
int number2 = int.Parse(imput2);

if (number1 > number2)
{
    Console.Write($"Первое число {number1} больше чем второе: {number2}");
}
else if (number1 == number2)
{
    Console.Write($"Числа {number2} равны!");
}
else
{
Console.Write($"Второе число {number2} больше чем первое: {number1}");
} 
