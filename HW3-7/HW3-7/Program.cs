

int m, n, nod;
Console.WriteLine("Введите первое число");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
n = Convert.ToInt32(Console.ReadLine());

while (m != n)
{
    if (m > n)
    {
        m = m - n;
    }
    else
    {
        n = n - m;
    }
}

nod = n;
Console.WriteLine("наибольший общий делитель : " + nod);
