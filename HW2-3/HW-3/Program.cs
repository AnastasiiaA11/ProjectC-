// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите три числа");
Console.WriteLine("Введите первое число");
int A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int C = Convert.ToInt32(Console.ReadLine());

if (A < B && A < C)
    Console.WriteLine(A);
Console.WriteLine(Math.Min(B, C));
Console.WriteLine(Math.Max(B, C));

if (B < A && B<C)
{
    Console.WriteLine(B);
    Console.WriteLine(Math.Min(A, C));
    Console.WriteLine(Math.Max(A, C));
}
if (C < B && C < A);
{
    Console.WriteLine(C);
    Console.WriteLine(Math.Min(A, B));
    Console.WriteLine(Math.Max(A, B));

}

//знаю что Math.Max и Math.Min не изучали, но я погуглила и решила сделать так.