// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size)
{
    int[] array1 = new int[size];
    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(1, 10);
    }
    return array1;
}

void PrintArray(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
}

int GetSumOfOddIndex(int[] array3)
{
    int sum = 0;
    for (int i = 1; i < array3.Length; i = i + 2)
    {
        sum = sum + array3[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");
    return sum;
}

int length = 4;
int[] array = GetArray(length);
PrintArray(array);
Console.WriteLine();
GetSumOfOddIndex(array);
