// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetNumberFromArray(int[,] array3)
{
    Console.WriteLine("Для возврата элемента из массива введите номер строки = ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Для возврата элемента из массива введите номер столбца = ");
    int n = int.Parse(Console.ReadLine());


    if (m < array3.GetLength(0) && n < array3.GetLength(1))
    {
        Console.WriteLine($"В указанной позиции хранится элемент {array3[m, n]}");
    }
    else
    {
        Console.WriteLine("В массиве нет элемента с подобной позицией");
    }
}

Console.Write("Введите количество строк массива m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива n = ");
int n = int.Parse(Console.ReadLine());
int[,] arr = GetArray(m, n, 0, 10);
PrintArray(arr);
GetNumberFromArray(arr);
