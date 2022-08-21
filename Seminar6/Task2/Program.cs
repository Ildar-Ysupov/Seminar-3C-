// Задача 40:
//  Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
//  Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы
//  двух других сторон.

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if(a + b > c && a + c > b && b + c > a) Console.WriteLine("Треугольник с сторонами такой длины существует.");
else Console.WriteLine("Треугольник с сторонами такой длины не существует.");
