// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите значение b1 = ");
double b1 = double.Parse(Console.ReadLine()); //a
Console.Write("Введите значение k1 = ");
double k1 = double.Parse(Console.ReadLine()); //b
Console.Write("Введите значение b2 = ");
double b2 = double.Parse(Console.ReadLine()); //c
Console.Write("Введите значение k2 = ");
double k2 = double.Parse(Console.ReadLine()); //d

double[] array = GetCoordinates(b1, k1, b2, k2);
Console.WriteLine(string.Join(" ", array));

double[] GetCoordinates(double a, double b, double c, double d)
{
    int size = 2;
    double[] arr = new double[size];
    arr[0] = (c - a) / (b - d);
    arr[1] = b * arr[0] + a;
    return arr;
}