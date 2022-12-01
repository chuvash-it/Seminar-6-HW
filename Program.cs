﻿//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения уравнения y = k1 * x + b1");
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значения уравнения y = k2 * x + b2");
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double [] array = {k1, b1, k2, b2};
intersection(array);
void intersection (double [] arr)
{
    double x = (arr[3] - arr[1]) / (arr[0] - arr[2]);
    double y = arr[0] * x + arr[1];
    if (arr[0] == arr[2]) Console.WriteLine("прямые параллельны");
    else 
    Console.WriteLine($"Точка пересечения прямых в координатах:{x}; {y}");
}
