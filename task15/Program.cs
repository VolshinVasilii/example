// 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0 || number > 7)
    Console.WriteLine("Вы ввели номер НЕ дня недели");
else if (number > 5)
    Console.WriteLine("Выходной");
else Console.WriteLine("Еще не выходной");
