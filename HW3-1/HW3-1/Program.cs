
//Console.WriteLine("Введите число которое хотите возвести в степень");
//nt firstNumber= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите степень");
//int secondNumber = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("firstNumber^secondNumber = " + Math.Pow(firstNumber, secondNumber));


Console.WriteLine("Введите число которое хотите возвести в степень");
int A= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int B = Convert.ToInt32(Console.ReadLine());

double C = 1;
if (B >= 0)
{
    for (int i = 0; i < B; i++)
    {
        C = C * A;
    }
    Console.WriteLine($"Ответ:{A}^{B}={C}");
}
else
{
    for (int i = 0; i < Math.Abs(B); i++)

    {
        C = C * A;
    }

    C = 1 / C;
    Console.WriteLine($"Ответ:{C}");
}

