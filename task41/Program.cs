// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int[] CreateArray(int arr)
{
    int[] array = new int[arr];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите следующее число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int NumberOfPositiveDigits(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите количество вводимых цифр");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
    Console.WriteLine("Вы ввели неверное количество вводимых цифр, попробуйте заново");
else
{
int[] array = CreateArray(number);
int numOfPosDigits = NumberOfPositiveDigits(array);
PrintArray(array);
Console.WriteLine($"Количество положительных введенных элементов: {numOfPosDigits}");
}