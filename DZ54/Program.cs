//   Задача 54:
//  Задайте двумерный массив. Напишите программу, которая упорядочит по
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = 3;
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
for (int i = 0; i < resultArray.GetLength(0); i++)
{
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        for (int m = 0; m < resultArray.GetLength(1) - 1; m++)
        {
            if (resultArray[i, m] < resultArray[i, m + 1])
            {
                int temp = 0;
                temp = resultArray[i, m];
                resultArray[i, m] = resultArray[i, m + 1];
                resultArray[i, m + 1] = temp;
            }
        }
    }
}
PrintArray(resultArray);