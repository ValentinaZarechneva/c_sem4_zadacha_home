﻿// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите число: ");
int n2 = Convert.ToInt32(Console.ReadLine());


Console.Write($"{Math.Pow(n1, n2)} ");
