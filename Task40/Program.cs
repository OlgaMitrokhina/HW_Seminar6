﻿// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите 3 числа и программа проверит, может ли существовать треугольник с сторонами такой длины: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2)
{
    Console.WriteLine("Такой треугольник существует");
}
else
{
    Console.WriteLine("Такого треугольника не существует");
}
