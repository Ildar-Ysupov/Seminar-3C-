// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[5];
int i = 0;
int size = array.Length;
int count = 0;
while (i < size) 
{
    array[i] = new Random().Next(100,1000);
    i++;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

for (int j = 0; j < size; j++)
{
    if (array[j]%2 == 0) count++;
}
Console.WriteLine($"Count: {count}");
