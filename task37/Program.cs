// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

void GetMultipliedEl(int[] array3)
{
    for (int i = 0; i < array3.Length / 2; i++)
    {
        Console.Write($"{array3[i] * array3[array3.Length - i - 1]} ");
    }

    if (array3.Length % 2 != 0)
    {
        Console.Write($"{array3[array3.Length / 2]} ");
    }
}

int length = 7;
int[] array = GetArray(length);
PrintArray(array);
Console.Write("-> ");
GetMultipliedEl(array);

