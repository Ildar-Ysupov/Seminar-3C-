// Задача 56:
//  Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
//  наименьшей суммой элементов: 1 строка.

int rows = 4;
int columns = 4;

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] resultArray = GetArray(rows, columns);
PrintArray(resultArray);
Console.WriteLine();
int lineNum = 0;
int minSum = Int32.MaxValue;

for (int i = 0; i < resultArray.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        sum += resultArray[i, j];
    }
    Console.Write(sum + " ");
    if (sum < minSum)
    {
        minSum = sum;
        lineNum = i + 1;
    }
}
Console.WriteLine();
Console.WriteLine(lineNum);
