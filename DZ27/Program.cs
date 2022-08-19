// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int n = number ; n > 0; n = n / 10) 
{
    sum = sum + n % 10;
}
Console.WriteLine($"Сумма цифр числа {number} = {sum}");