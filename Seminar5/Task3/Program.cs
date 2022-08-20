
// int [] array = {0, -1, -2, 3, 4, 5, 6, 7};
// int searchNumber = Convert.ToInt32(Console.ReadLine());
// bool flagResult = false; 
// // flagResult = false - element not found
// // flagResult = true - element found
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == searchNumber) 
//     {
//         flagResult = true;
//         break; // break - ломает цикл
//     }
// }

// if (flagResult) System.Console.WriteLine("element found");
// // flagResult == true => if (flagResult)
// else System.Console.WriteLine("element not found");

// int [] array = {0, -1, -2, 3, 4, 5, 6, 7};
// int searchNumber = Convert.ToInt32(Console.ReadLine());
// string flagResult = "не найден"; 
// // flagResult = false - element not found
// // flagResult = true - element found
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == searchNumber) 
//     {
//         flagResult = "найден";
//         break; // break - ломает цикл
//     }
// }

// Console.WriteLine($"Элемент {searchNumber}: {flagResult}");


// 35 задача:

int [] array = {0, -1, -2, 3, 4, 5, 6, 7,66,35,88};
// [10;99]

int count = 0; // количество чисел, принадлежащих диапазону [10;99]

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99) count++;
}
Console.WriteLine($"Количество элементов в диапазоне от 10 до 99 = {count}");
