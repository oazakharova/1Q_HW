// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 || 3 4 | 2*3+4*3 2*4+4*3 | строка на столбец | a00*b00+a01*b10  a00*b01+a01*11
// 3 2 || 3 3 | 3*3+2*3 3*4+2*3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 5);
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

int[,] GetMultipliedArray(int[,] arr1, int[,] arr2)
{
    int[,] mulipliedArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < mulipliedArr.GetLength(0); i++)
    {
        for (int j = 0; j < mulipliedArr.GetLength(1); j++)
        {
            mulipliedArr[i, j] = 0;
            for (int k = 0; k < arr1.GetLength(0); k++) // ввели еще одну переменную для того, чтобы обойти создание нового элемента, когда меняются i и j
            {
                mulipliedArr[i, j] = mulipliedArr[i, j] + (arr1[i, k] * arr2[k, j]);
            }
        }
    }
    return mulipliedArr;
}

Console.Write("Введите количество строк первого массива m = ");
int m1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива n = ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк второго массива m = ");
int m2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второго массива n = ");
int n2 = int.Parse(Console.ReadLine());

if (n1 == m2)
{
    int[,] inArray1 = GetArray(m1, n1);
    PrintArray(inArray1);
    Console.WriteLine();
    int[,] inArray2 = GetArray(m2, n2);
    PrintArray(inArray2);
    Console.WriteLine();
    PrintArray(GetMultipliedArray(inArray1, inArray2));
}
else
{
    Console.WriteLine("Проверка на возможность умножения матриц не пройдена. n1 должен быть равен m2");
}

