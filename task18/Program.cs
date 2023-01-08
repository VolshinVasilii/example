// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
string numOfQuarter = Console.ReadLine();
string result = Quarter(numOfQuarter);
Console.WriteLine(result);

string Quarter(string numOfQua)
{
    if (numOfQua == "1") return "x > 0 и y > 0";
    if (numOfQua == "2") return "x < 0 и y > 0";
    if (numOfQua == "3") return "x < 0 и y < 0";
    if (numOfQua == "4") return "x > 0 и y < 0";
    return "Неверный номер четверти";
}