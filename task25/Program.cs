// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно возвести число ");
int pow = Convert.ToInt32(Console.ReadLine());
int resu = Powpow(number, pow);
Console.WriteLine($"{number} в степени {pow} = {resu}");

int Powpow(int num, int step)
{
    int result = 1;
    int count = 0;
    int res = 0;
    while (count < step)
    {
        res = num * num;
        result = result * num;
        count++;
    }
    return result;
}