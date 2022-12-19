// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Размер массива, минимальное значение и максимальное значение вводим через консоль
// Для генерации вещественных числе, по аналогии с int, есть функция NextDouble()
// [3 7 22 2 78] -> 76

Console.Write("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите min значение: ");
int minvalue = int.Parse(Console.ReadLine()!);
Console.Write("Введите max значение: ");
int maxvalue = int.Parse(Console.ReadLine()!);

double[] arr = FillArray(num, minvalue, maxvalue);
PrintArray(arr);
double maxrand = MaxFunc(arr);
double minrand = Minfunc(arr);
Console.WriteLine($" -> {Math.Round(DiffFunc(maxrand, minrand), 2)}");


double[] FillArray(int n, int min, int max)
{
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 3);  
    }
    return array;
}

void PrintArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");

    }
}

double MaxFunc(double[] array)
{
   double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
    return max;
}

double Minfunc(double[] array)
{
    double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
    return min;
}

double DiffFunc(double max, double min)
{
    double diff = max - min;
    return diff;
}