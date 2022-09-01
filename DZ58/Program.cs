//   Задача 58:
//  Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rowsA = 2;
int columnsA = 2;
int rowsB = 2;
int columnsB = 2;
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,5);
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
int[,] arrayA = GetArray(rowsA, columnsA);
int[,] arrayB = GetArray(rowsB, columnsB);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
if (columnsA == rowsB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(0); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
            Console.Write(arrayC[i, j] + " ");    
        }
        Console.WriteLine();
    }
}
else Console.WriteLine("Матрицы перемножить невозможно.");
