// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] array1 = new double[size];
    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(1, 100);
    }
    return array1;
}

void PrintArray(double[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
}

double GetMaxMinDiff(double[] array3)
{
    double dif = 0;
    double max = 0;
    double min = array3[0];

    foreach (double el in array3)
    {
        if (el < min)
        {
            min = el;
        }
        //else
        //{
        if (el > max)
        {
            max = el;
        }
        //}
    }
    dif = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементами = {dif}");
    return dif;
}

int length = 6;
double[] array = GetArray(length);
PrintArray(array);
Console.WriteLine();
GetMaxMinDiff(array);
