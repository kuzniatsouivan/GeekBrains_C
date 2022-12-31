// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(FromN1(n));

string FromN1(int n)
{
   
    if (n == 1)
    {
        return $"{n}";
    }
    else
    {
        return  n  + ", " + FromN1(n - 1);
    }
}