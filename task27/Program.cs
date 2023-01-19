// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// // 9012 -> 12

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumOfNumbers(number);
Console.WriteLine($"Сумма цифр числа {number} = {result}");


int SumOfNumbers(int num)
{
    int sum = 0;
    if (num < 0)
        num = -1 * num;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
