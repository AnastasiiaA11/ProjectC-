// See https://aka.ms/new-console-template for more information

Console.WriteLine("Jпределить какой четверти принадлежит точка с координатами (X, Y)");

Console.WriteLine("Введите число X: ");
int X=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine($"Ответ:первая четверть");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine($"Ответ:вторая четверть");
}
else if (X < 0 && Y < 0) {
    Console.WriteLine($"Ответ:третья четверть");
}
else if (X > 0 && Y < 0) {
    Console.WriteLine($"Ответ:четвертая четверть");
}
