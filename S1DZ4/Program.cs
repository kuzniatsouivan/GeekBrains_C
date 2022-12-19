// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
string imput1 = Console.ReadLine()!;
int number1 = int.Parse(imput1);

Console.Write("Введите второе число: ");
string imput2 = Console.ReadLine()!;
int number2 = int.Parse(imput2);

Console.Write("Введите третье число: ");
string imput3 = Console.ReadLine()!;
int number3 = int.Parse(imput3);

if (number1 > number2)
{

    if (number1 > number3)
    {
        Console.Write($"Самое большое число {number1}");
    }
    else
    {
        Console.Write($"Самое большое число {number3}");
    }
}
else
{
    if (number2 > number3)
    {
        Console.Write($"Самое большое число {number2}");
    }
    else
    {
        Console.Write($"Самое большое число {number3}");
    }

}