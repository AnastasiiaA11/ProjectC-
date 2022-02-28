
Console.WriteLine("Введите одно число");
int N = Convert.ToInt32(Console.ReadLine());
int z=0;
int tmp;
while (N!=0)
{
    tmp = N % 10;
    z *= 10;
    z += tmp;
    N /= 10;
    
    
}
Console.WriteLine($"Зеркальное значение числа: {z}");