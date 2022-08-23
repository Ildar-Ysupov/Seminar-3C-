// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите колличесво (M) чисел:  ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];

for (int i = 0; i < M; i++)
{
    Console.Write($"Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int countPositiv = 0; // колличество положительных чисел
for (int j = 0; j < M; j++)
{
    if (array[j] > 0) countPositiv++;     
}
Console.Write($"Колличество чисел > 0 = {countPositiv}");        