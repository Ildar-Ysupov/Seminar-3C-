// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int a = 0;
// int b = 1;
// Console.WriteLine("Введите количество цифр Фибоначчи: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{a} {b}");
// int c = 0;
// for (int i = 2; i < N; i++)
// {
//     c = a + b;
//     Console.Write($" {b} ");
//     a = b;
//     b = c;
// }

int N = 10;

int firstElement = 0; // Первое число по определению равно 0

int secondElement = 1; // Второе число равно 1

Console.WriteLine(firstElement);  // 1 число
Console.WriteLine(secondElement); // 2 число

for (int i = 3; i <= N; i++)
{
    int nextElement = firstElement + secondElement;
    Console.WriteLine(nextElement);
    firstElement = secondElement;
    secondElement = nextElement;
}
