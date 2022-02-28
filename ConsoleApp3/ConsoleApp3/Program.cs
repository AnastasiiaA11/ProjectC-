// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите значение А: ");
string A=Console.ReadLine();
Console.WriteLine("Введите значение В: ");
string B = Console.ReadLine();
string C;
C = A;
A = B;
B = C;

Console.WriteLine($"A={A}");
Console.WriteLine($"B={B}");


