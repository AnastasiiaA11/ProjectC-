
Console.WriteLine("Введите число");
int A= Convert.ToInt32(Console.ReadLine());



for (int i = 1; i <= 1000; i++) {
    if (i % A == 0)
      {
        Console.WriteLine(i);
      }
    }

