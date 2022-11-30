// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


int max = 0;

for (int i = 0; i < 3; i++)
{
    Console.Write("Введите " + (i+1) + "е число ");
    int A = int.Parse(Console.ReadLine());

    if (A > max)
    {
        max = A;
    }
}
Console.WriteLine("Наибольшее число - " + max);