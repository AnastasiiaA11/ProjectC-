

Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
bool check = false;

while (A != 0)
{
    int tmp = A % 10;
    while (B != 0)
    {
        int tMppp = B % 10;
        if (tmp == tMppp) 
        {
            check = true;
        }
        B = B / 10;
    }
    A = A / 10;
}
    if (check == true)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }




