// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите первое натуральное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int result = SumOfDigits(firstNumber, secondNumber);
if (firstNumber < 0 || secondNumber < 0 || firstNumber > secondNumber)
    Console.WriteLine("Вы ввели не натуральное число или первое число больше второго");
else
    Console.WriteLine($"Сумма элементов в промежутке от {firstNumber} до {secondNumber} = {result}");

int SumOfDigits(int firstNum, int secondNum)
{
    if (firstNum > secondNum)
        return 0;
    return firstNum + SumOfDigits(firstNum + 1, secondNum);
}