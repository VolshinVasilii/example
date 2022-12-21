// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int res = Multiplicity(numberOne, numberTwo);
Console.WriteLine(res == 0 ? "Кратно" : $"не кратно, остаток от деления {res}");
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine($"Не кратно, остаток {div}");
// }

int Multiplicity(int numOne, int numTwo)
{
    return numOne % numTwo;
}

