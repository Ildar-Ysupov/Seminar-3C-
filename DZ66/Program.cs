//   Задача 66:
//  Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n, int sum = 0)
{
    sum = m++;
    if (m > n) return sum;

    return SumNumbers(m, n) + sum;
}
Console.WriteLine($"Сумма цифр от {M} до {N} = {SumNumbers(M, N)}");