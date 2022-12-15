Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberTwo * numberTwo == numberOne) 
{
    Console.WriteLine($"{numberOne} является квадратом {numberTwo}");
}
else
{
    Console.WriteLine($"{numberOne} не является квадратом {numberTwo}");
}
