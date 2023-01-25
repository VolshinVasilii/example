// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FindX(double a, double b, double c, double d)
{
    double x = (c - a) / (b - d);
    return x;
}

double FindY(double a, double b, double c, double d)
{
    double x = FindX(a, b, c, d);
    double y = d * x + c;
    return y;
}

Console.WriteLine("Введите координаты точек k1, b1, k2, b2");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double x = FindX(b1, k1, b2, k2);
double y = FindY(b1, k1, b2, k2);
if (k1 == k2) Console.WriteLine("Прямые параллельны");
else
{
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}, {y})");
}
