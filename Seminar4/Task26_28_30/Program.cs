// Задача 26:
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int number = Convert.ToInt32(Console.ReadLine());

// int GetCountNumbers(int digit)
// {
//     int count = 0; // чисел 0
//     while (digit > 0)
//     {
//         count++;
//         digit /= 10;
//     }
//     return count;
// }

// Console.WriteLine(GetCountNumbers(number));

// Задача 28:
//  Напишите программу, которая принимает на вход число N и выдаёт
//   произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int number = Convert.ToInt32(Console.ReadLine());

// int GetMultiply(int num)
// {
//     // [1;N]
//     int result = 1; //умножение на 0 даст вам 0
//     // 5! = 1*2*3*4*5
//     for (int i = 2; i <= num; i++) // 1! = 1,
//     {
//         result *= i;
//     }
//     return result;
// }
// Console.WriteLine($"Произведение чисел от 1 до {number} = {GetMultiply(number)}");

// Задача 30:
//  Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] GetBinaryArray(int size)
{
    int[] result = new int[size]; // size = 5; result = [0,0,0,0,0]
    for (int i = 0; i < result.Length; i++) // size = result.Length
    {
        //[min; max+1);
        result[i] = new Random().Next(2); //Если указано одно число, то вы идете от 0 до этого числа
    }
    return result;
}

int [] testArray = GetBinaryArray(8);
Console.WriteLine($"Результат: [ {String.Join("; ", testArray)} ]");
