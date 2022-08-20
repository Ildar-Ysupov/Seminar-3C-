// Задача 33:
//  Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] array = new int[9];
// int i = 0;
// int arraySize = array.Length; 
// while (i < arraySize)
// {
//     array[i] = new Random().Next(-9, 10);
//     i++;
// }
// Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");
// Console.Write(" Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for (i = 0; i < arraySize; i++)
// {
//     if (array[i] == number) count++;
// }
// if (count == 0) Console.WriteLine($"Число {number} не входит в массив ");
// else Console.WriteLine($"Число входит в массив {number} ");

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[123];
int i = 0;
int arraySize = array.Length;
int count = 0;

while (i < arraySize)
{
    array[i] = new Random().Next(1000);
    i++;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");
for (i = 0; i < arraySize; i++)
{
    if (array[i] >= 10 && array[i] <= 99) count++;
}
Console.WriteLine($" {count}");
