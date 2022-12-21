// 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите положительное целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99)
    Console.WriteLine($"{number} -> третьей цифры нет");
else
{
    int result = ThirdDigit(number);
    Console.WriteLine(result);
}



int ThirdDigit(int num)
{
    if (num > 999)
        while (num > 999)
        {
            num = num / 10;
        }
    int res = num % 10;
    return res;
}
