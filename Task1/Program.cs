Console.Write("Введите координату по оси оХ: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оY: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0) Console.WriteLine("I четверть");
else if (x < 0 && y > 0) Console.WriteLine("II четверть");
else if (x < 0 && y < 0) Console.WriteLine("III четверть");
else if (x > 0 && y < 0) Console.WriteLine("IV четверть");
else System.Console.WriteLine("eror 404, quarter not found");
