// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите первое число не равное 0: ");
int A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число не равное 0: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число не равное 0: ");
int C = Convert.ToInt32(Console.ReadLine());
double X;
X = (double)(C - B) / A;

Console.WriteLine($"X равен={X}");
