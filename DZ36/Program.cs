// Задача 36:
//  Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
int i = 0;
int size = array.Length;
int sum = 0;
while (i < size) 
{
    array[i] = new Random().Next(-99,100);
    i++;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");
for (int j = 0; j < size; j++)
{
    if (j%2 != 0) sum += array[j];
}
Console.WriteLine($"Sum: {sum}");
