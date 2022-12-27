// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-5, 6);
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

int[,] GetSortedArray(int[,] array3)
{
    // int[,] result = new int[array3.GetLength(0), array3.GetLength(1)];

    for (int i = 0; i < array3.GetLength(0); i++)
    {

        for (int j = 0; j < array3.GetLength(1); j++)
        {
            for (int k = 0; k < array3.GetLength(1); k++)
            {
                if (array3[i, j] <= array3[i, k])
                {
                    int temp = array3[i, j];
                    array3[i, j] = array3[i, k];
                    array3[i, k] = temp;
                }
            }
        }
    }
    return array3;
}

Console.Write("Введите количество строк массива m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива n = ");
int n = int.Parse(Console.ReadLine());

int[,] arr = GetArray(m, n);
PrintArray(arr);
Console.WriteLine();
PrintArray(GetSortedArray(arr));