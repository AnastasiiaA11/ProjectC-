// See https://aka.ms/new-console-template for more information
Console.WriteLine("Выведите уравнение прямой в формате Y=AX+B"); 
Console.WriteLine("Введите первое X1: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое Y1: ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое X2: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое Y2: ");
double Y2 = Convert.ToInt32(Console.ReadLine());

double tmp1 = Y1 - Y2;
double tmp2 = X2 - X1;
double tmp3 = X1*Y2-X2*Y1;

double a=tmp1 / tmp2;
double b=tmp3 / tmp2;

Console.WriteLine($"y={a}*x+{b}");

