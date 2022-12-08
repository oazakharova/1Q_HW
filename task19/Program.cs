// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число - ");
int a = int.Parse(Console.ReadLine());

int a1 = a/10000;
int a5 = a%10;
//Console.WriteLine("1 и 5 цифры - " + a1 + "," + a5);


int a2 = (a/1000)%10;
int a4 = (a/10)%10;
//Console.WriteLine("2 и 4 цифры - " + a2 + "," + a4);

if (a1 == a5 && a2 == a4)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}