// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите желаемое количество чисел М = ");
int m = int.Parse(Console.ReadLine());
GetCount(m);

int GetCount(int size)
{
    int count = 0;
    int[] arr = new int[size];
    Console.WriteLine($"Введите {m} чисел, после каждого нажмите ВВОД");

    for (int i = 0; i < size; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
        if (arr[i] > 0) count++;
    }
    Console.WriteLine($"Введено {count} положительных элементов");
    return count;
}

