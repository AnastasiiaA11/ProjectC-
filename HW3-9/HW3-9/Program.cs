
Console.WriteLine("Введите одно число");
int N = Convert.ToInt32(Console.ReadLine());
int numberOdd = 0;

for (int i = 1; i <= N; i++) 
{
    if (i % 2 == 1) 
    {
        numberOdd++;
    }
   
}
Console.WriteLine($"количество нечетных цифр:{numberOdd}"); ;