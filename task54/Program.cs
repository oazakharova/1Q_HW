// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] GetSortedArray(int[,] array3)
{
    // int[,] result = new int[array3.GetLength(0), array3.GetLength(1)];

    for (int i = 0; i < array3.GetLength(0); i++)
    {

        for (int j = 0; j < array3.GetLength(1); j++)
        {
            int element;
            int flag = 0; // флаг для расчета количества изменений. Если изменений не было, то сортировка закончена

            if (flag != 0)
            {
                if (array3[i, j] < array3[i, j + 1])
                {
                    // element = array3[i, j];
                    // array3[i, j] = array3[i, j + 1];
                    // array3[i, j + 1] = element;
                    // flag++;
                }
            }
            else
            {
                // значит, пора переходить к новой строке
            }
        }
    }
}