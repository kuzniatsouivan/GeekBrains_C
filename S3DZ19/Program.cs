// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число из 5-ти чисел: ");
int n = Math.Abs(int.Parse(Console.ReadLine()!));

int[] array = new int[5];

for (int i = 0; i <= 4; i++)
{
    array[i] = n % 10;
    n = n / 10; 
}
if (array[0] == array[4] && array[1]== array[3])
{
    Console.WriteLine("Число является полиндроном");
}
else
{
    Console.WriteLine("Число неявляется полиндроном");
}

// Другой вариант решения:

// Console.WriteLine("Введите число из 5-ти чисел: ");
// string array = Console.ReadLine()!;

// int i = 0;

// if  (array[0] == '-' ) i = 1;

// if (array[i] == array[4+ i ] && array[1 +i]== array[3 +i])
// {
//     Console.WriteLine("Число является полиндроном");
// }
// else
// {
//     Console.WriteLine("Число неявляется полиндроном");
// }