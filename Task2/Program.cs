// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат
// точек в этой четверти (x и y).

// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Math.Round (число, кол-во знаков после запятой)
// Math.Sqrt(число, от которого берется корень)
// Math.Pow(2,3); // 2 в 3 степени = 2*2*2 = 8

// // Console.Write("Введите номер четверти: ");
// // int number = Convert.ToInt32(Console.ReadLine());

// // if (number == 1) Console.WriteLine("x > 0 ; y > 0");
// // else if (number == 2) Console.WriteLine("x < 0 ; y > 0");
// // else if (number == 3) Console.WriteLine("x < 0 ; y < 0");
// // else if (number == 4) Console.WriteLine("x > 0 ; y < 0");
// //d = √((хА – хВ)2 + (уА – уВ)2

// Console.Write("Введите координату по оси оХ: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по оси оY: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату 2 по оси оХ: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату 2 по оси оY: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// // Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// // A (3,6); B (2,1) -> 5,09
// // A (7,-5); B (1,-1) -> 7,21

// double result = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
// Console.WriteLine($"result = {Math.Round(result,2)}");



// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (count <= number)
{
    Console.Write(Math.Pow(count,2) + " ");
    count++;
}