// Задача 24:
//  Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36  

// 1: способ

// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());

// // sum [1;A]
// // for (начало; условие; увеличение счётчика)
// int sum = 0;

// for (int i = 1; i <= A; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"Сумма элементов от 1 до {A} = {sum}");

// 2: Способ через метод и цикл while.

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
// метод - функция созданная собственноручно
// тип_возвращаемого_значения (int; string; double) NameOfMethod (params)
// int GetSumNumbers(int number) - получить сумму чисел где: int-возвращаем(return)
// переменную числового типа; GetSumNumbers-имя метода; (int number)-параметор метода.
int GetSumNumbers(int number)
{
    int sum = 0;
    int start = 1;
    while(start <= number)
    {
        sum += start;
        start ++;
    }
    return sum;
}
Console.WriteLine($"Сумма элементов от 1 до {A} = {GetSumNumbers(A)}");
// return аналог Console.WriteLine
// return вщзвращает результат к месту вызова метода
