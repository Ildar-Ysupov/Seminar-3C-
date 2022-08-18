// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите пятизначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("Число является полиндромом. ");
}
else
Console.WriteLine("Число не является полиндромом. ");