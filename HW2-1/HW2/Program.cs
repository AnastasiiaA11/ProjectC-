// See https://aka.ms/new-console-template for more information


double A, B;
Console.WriteLine("Введите первое число: ");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
B = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    Console.WriteLine($"Результат A + B = {A + B}");
}
else if(A == B)
{
    Console.WriteLine($"Результат A * B = {A * B}");
}
else if (A < B);
{
    Console.WriteLine($"Результат A - B = {A - B}");
}
            
 




