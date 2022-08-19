// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B. 
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int GetDegreeNumbers(int number)
{
    int result = a;
    int start = 2;
    while (start <= b)
    {
        result = result * a;
        start++;
    }
     return result;
}
Console.WriteLine($"Число {a} в степени {b} = {GetDegreeNumbers(a)}");