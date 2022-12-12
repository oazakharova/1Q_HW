// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine());
Print(GetSumOfNumbers(n));

int GetSumOfNumbers (int num)
{
    int sum = num%10;
    num = num/10; 
    while (num > 0)
    {
        sum = sum + (num%10);
        num = num/10;
    } 
    return sum;
}

void Print (int number)
{
    Console.Write(number);
}

