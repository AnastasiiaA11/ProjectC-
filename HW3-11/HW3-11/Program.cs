
Console.Write("Введите целое положительное  число (N): ");
int N = Convert.ToInt32(Console.ReadLine());
int y;
for (int i = 1; i < N; i++)
{
    int summPositive = 0;
    int summNegative = 0;
    int x=i;
    while (x != 0)
    {
        y = x % 10;
        if (y % 2 == 0)
        {
            summPositive = summPositive + y;
        }
        else
        {
            summNegative = summNegative + y;
        }
        x = x / 10;

    } 
    if (summPositive > summNegative)
    {
        Console.Write(i +" ");
    }
}

 
