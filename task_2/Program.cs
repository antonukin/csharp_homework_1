//      Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//      2, 3, 7 -> 7
//      44 5 78 -> 78
//      22 3 9 -> 22

Console.WriteLine("Введите первое число ");
string numberOne = Console.ReadLine();
double a = Double.Parse(numberOne);
Console.WriteLine("Введите второе число");
string numberTwo = Console.ReadLine();
double b = Double.Parse(numberTwo);
Console.WriteLine("Введите третье число");
string numberThree = Console.ReadLine();
double d = Double.Parse(numberThree);

double max = a;
{
    if(a > max)
    {      
        max = a;
    }
    if (b > max)
    {
        max = b;
    }
    if (d > max)
    {
        max = d;
    }
}
Console.WriteLine($"Самое большое число {max}");