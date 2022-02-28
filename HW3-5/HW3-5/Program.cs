

Console.WriteLine("Введите первое число");
int A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
int z = 0;

if (A < B)
{
    for (int i = A; i <= B; i++)
    {
        if (i % 7 == 0)
        {
            z = z + i;
        }
    }
}
else
{
    for (int i = B; i < A; i++)
    {
        if (i % 7 == 0)
        {
            z = z + i;

        }
    }
}
Console.WriteLine(z);

