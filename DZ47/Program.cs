// Задача 47.
//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] BinariArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            // array[i,j] = Math.Round(new Random().NextDouble()*10,1);
            array[i,j] = Math.Round(new Random().Next(-10,10) + new Random().NextDouble(),2);
 
        }
    }
    return array;
}
double[,] resultArray = BinariArray(rows, columns);
PrintArray(resultArray);
void PrintArray(double[,] tableArray)
{
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            Console.Write(tableArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
}