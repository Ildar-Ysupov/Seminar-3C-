// Задача 38:
//  Задайте массив вещественных чисел. Найдите разницу между максимальным и
//   минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[4];
int i = 0;
int size = array.Length;
while (i < size)
{
    array[i] = Math.Round(new Random().NextDouble() * 100, 2);
    // array[i] = Math.Round(new Random().NextDouble() , 3) + new Random().Next(10);
    i++;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");
double min = array[0];
double max = array[0];
for (i = 0; i < size; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
    
}
Console.WriteLine($"Разница между {max} и {min} = {max - min}");