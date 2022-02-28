
Console.WriteLine("Введите число");
int A=Convert.ToInt32(Console.ReadLine());
int maximumDivisor = 0;

for (int i = 1; i < A; i++)
{
    if (A % i == 0)
    { 
    
        maximumDivisor = i;
    }
}
Console.WriteLine($"Наибольший делитель: {maximumDivisor}");
