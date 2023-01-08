// 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int number1 = 1;
// while (number1 <= number)
// {
//     int cubeOfNum = number1 * number1 * number1;
//     Console.WriteLine($"{number1} | {cubeOfNum}");
//     number1 = number1 + 1;
// }

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
    TableSquare(number);
else
{
    Console.WriteLine("Введено некорректное число");
}

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}\t{Math.Pow(count, 2) * count}");
        count++;
    }
}
