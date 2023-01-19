﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// string result = ConverteDecToBin(123);
// Console.WriteLine(result);

// string ConverteDecToBin(int num)
// {
//     string residue = string.Empty;
//     while (num > 0)
//     {
//         residue = num % 2 + residue;
//         num /= 2;
//     }
//     return residue;
// }

Console.Write("Введите число для преобразования в двоичную систему счисления: ");
int number = Convert.ToInt32(Console.ReadLine());
int convertDecimalToBinary = ConvertDecimalToBinary(number);
Console.WriteLine(convertDecimalToBinary);

int ConvertDecimalToBinary(int num)
{
    int result = 0;
    int multiplyer = 1;
    while (num != 0)
    {
        result = result + num % 2 * multiplyer;
        num = num / 2;
        multiplyer *= 10;
    }
    return result;
}

