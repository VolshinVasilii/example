// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите целое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int res = SecondDigit(number);
Console.WriteLine(res);

int SecondDigit(int num)
{
    return num / 10 % 10;
}