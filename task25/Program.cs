// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

Print(GetDegree(a, b));

int GetDegree (int num1, int num2)
{
    int degree = num1;
    int count = 1;
    while (count < num2)
    {
        degree = degree * num1;
        count++;
    }
    return degree;
}

void Print (int number)
{
    Console.Write(number);
}


