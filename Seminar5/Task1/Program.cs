// Задача 31:
//  Задайте массив из 12 элементов, заполненный случайными числами из
//  промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//  сумма отрицательных равна -20.

// int[] array = new int[12];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
// }  массив из случайных чисел [-9, 9].

int[] array = new int[12]; // array = [0,0,0...0]

int resultPositive = 0; // Сумма положительных чисел
int resultNegative = 0; // Сумма отрицательных чисел
// for(int i = 0; i < array.Length; i++)
int i = 0; // i - index(int i = 0)
int arraySize = array.Length; // Длина массива - количество элементов

while (i < arraySize) // i < array.Length
{
    array[i] = new Random().Next(-9, 10); // [-9;9]
    // i++ - увеличение индекса
    i++;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

for (int j = 0; j < arraySize; j++)
{
    // Число отрицательное
    if (array[j] < 0) resultNegative += array[j]; // resultNegative = resultNegative + array[i]
    // Положительные числа и 0
    else resultPositive += array[j]; // resultPositive = resultPositive + array[j] 
}

Console.WriteLine($"Сумма пол. = {resultPositive}, сумма отр. = {resultNegative} ");

