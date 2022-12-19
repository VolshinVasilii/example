Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SquareNum(number1, number2) ? "Да" : "Нет");

bool SquareNum(int num1, int num2)
{
    return number1 == number2 * number2 || number2 == number1 * number1;
}