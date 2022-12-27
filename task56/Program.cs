// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-9, 10);
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

int GetMinimalSumOfElements(int[,] array3)
{
    int minimalSumOfElements = int.MaxValue; //минимальной сумме присвоено максимально возможное значение диапазона инт. Так я решаю проблему с присвоением 0 и ситуацией, когда массив состоит только из положит чисел (в таком случае мин сумма остается ==0, а строки с такой суммой элементов нет)
    int minRow = 0;
    int sum = 0;
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            sum = sum + array3[i, j];
        }
        if (sum < minimalSumOfElements)
        {
            minimalSumOfElements = sum;
            minRow = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Наименьшая сумма элементов содержится в {minRow}й строке");
    return minRow;
}

Console.Write("Введите количество строк прямоугольного массива m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов прямоугольного массива (n не может быть = m) n = ");
int n = int.Parse(Console.ReadLine());

if (m == n)
{
    Console.WriteLine("Вы ввели равные m и n. В таком случае массив не является прямоугольным. Просьба перезапустить программу и ввести корректные данные");
}
else
{
    int[,] arr = GetArray(m, n);
    PrintArray(arr);
    GetMinimalSumOfElements(arr);
}