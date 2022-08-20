// Задача 32:
//  Напишите программу замена элементов массива: положительные элементы замените
//  на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new int[4];

int i = 0;
int arraySize = array.Length; 
while (i < arraySize)
{
    array[i] = new Random().Next(-9, 10);
    i++;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");
for (int j = 0; j < arraySize; j++)
{
    array[j] *= -1;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)}");