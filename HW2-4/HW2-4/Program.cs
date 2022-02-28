// See https://aka.ms/new-console-template for more information


Console.WriteLine(" Вывести в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0");
Console.WriteLine("Введите число А:  ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:  ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C:  ");
int C = Convert.ToInt32(Console.ReadLine());
int X1;
int X2;

double D = ((B*B)-4*(A*C));

if (D > 0)
{
    X1 = ((int)((-B) + (Math.Sqrt(D)) / (2 * A)));
    X2 = ((int)((-B) - (Math.Sqrt(D)) / (2 * A)));
    Console.WriteLine($"Ответ: X1={X1}; X2={X2}");
}
else if (D == 0)
{
    double X = ((double)(-B) / (2 * A));
    Console.WriteLine($"Ответ: Есть один корень: {X}");
}
else if (D < 0)
{
    Console.WriteLine($"Ответ: нет корней");
}


//Вычислить дискриминант по формуле d = b2 — 4ac.
//Если дискриминант больше нуля, то вычислить два корня уравнения:
//x1 = (-b +√d) / 2a
//x2 = (-b -√d) / 2a
//Если дискриминант равен нулю, то вычислить только один корень (второй будет равен ему).
//Если дискриминант отрицателен, то вывести сообщение, что корней нет.