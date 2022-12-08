// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//√((x2-x1)^2 )+(y2-y1)^2+(z2-z1)^2

Console.Write("Введите первую координату числа А - ");
int ax = int.Parse(Console.ReadLine());
Console.Write("Введите вторую координату числа А - ");
int ay = int.Parse(Console.ReadLine());
Console.Write("Введите третью координату числа А - ");
int az = int.Parse(Console.ReadLine());

Console.Write("Введите первую координату числа B - ");
int bx = int.Parse(Console.ReadLine());
Console.Write("Введите вторую координату числа B - ");
int by = int.Parse(Console.ReadLine());
Console.Write("Введите третью координату числа B - ");
int bz = int.Parse(Console.ReadLine());

double result = Math.Sqrt( Math.Pow((bx-ax), 2) + Math.Pow((by-ay), 2) + Math.Pow((bz-az), 2));
Console.Write("Расстояние между двумя точками = " + Math.Round(result, 2));

