

Console.WriteLine("Введите число куба числа N");
int enteredNumber = Convert.ToInt32(Console.ReadLine());

int middle = 0;
int numberRight = 0;
int numberLeft = enteredNumber;

do
{
    middle = (numberRight + numberLeft) / 2;
    if (Math.Pow(middle, 3) < middle)
    {
        numberRight = middle;
    }
    else
    {
        numberLeft = middle;
    }
}
while (Math.Pow(middle, 3) != enteredNumber);
Console.WriteLine(middle);


