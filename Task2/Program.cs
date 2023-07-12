﻿/* Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double ReadDouble(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Task43");

double k1 = ReadDouble("Введите k1 -> ");
double b1 = ReadDouble ("Введите b1 -> ");
double k2 = ReadDouble("Введите k2 -> ");
double b2 = ReadDouble("Введите b2 -> ");

double x = (b2 - b1) / (k1 -k2);
double y = k1 * x + b1;
System.Console.WriteLine($"Координаты точки пересечения прямых : ({x}; {y})");
