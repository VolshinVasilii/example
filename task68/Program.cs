// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое натуральное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int result = AckermannFunction(firstNumber, secondNumber);
if (firstNumber >= 0 && secondNumber >= 0)
    Console.WriteLine($"m = {firstNumber}, n = {secondNumber} -> A(m,n) = {result}");
else
    Console.WriteLine("Вы ввели не натуральное число");

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if ((m > 0) && (n == 0))
        return AckermannFunction(m - 1, 1);
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

