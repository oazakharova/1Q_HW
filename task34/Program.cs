// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int size)
{
    int[] array1 = new int[size];
    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(100, 1000);
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

int GetCountOfEvenNumbers(int[] array3)
{
    int count = 0;
    for (int i = 0; i < array3.Length; i++)
    {
        if (array3[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четных элементов = {count}");
    return count;
}

int length = 10;
int[] array = GetArray(length);
PrintArray(array);
Console.WriteLine();
GetCountOfEvenNumbers(array);




