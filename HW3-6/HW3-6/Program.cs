
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int oneNumber = 1;
int twoNumber = 1;
int fibonacchi = 0;


if (N > 2)
{
    for (int i = 3; i <= N; i++)
    {
        fibonacchi = oneNumber + twoNumber;
        twoNumber = oneNumber;
        oneNumber = fibonacchi;
    }
    Console.WriteLine(fibonacchi);
}
else if (N==1 || N==2)
{
    Console.WriteLine("Ответ: 1");
}
else
{
    Console.WriteLine("Некорректное значение");
}