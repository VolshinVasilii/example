// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     double[,] matrix = new double[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
//             else Console.Write($"{matrix[i, j],5}  ");
//         }
//         Console.WriteLine("]");
//     }
// }

// int[] Create1dArray(int[,] matrix)
// {
//     int[] tempArray = new int[matrix.GetLength(1) * matrix.GetLongLength(0)];
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; i < matrix.GetLength(1); j++)
//         {
//             tempArray[k] = matrix[i, j];
//             k++;
//         }
//     }
//     Array.Sort(tempArray);
//    ` int differentElem = 0;
//     for (int i = 1; i < tempArray.Length; i++)
//     {
//         if (tempArray[i] != tempArray[i - 1]) differentElem++;
//     }
//     int[,] dict = new int[differentElem, 2];
//     dict[0,0] = tempArray[0];
//     for (int i = 1; i < tempArray.Length; i++)
//     {
//         if (dict[0,0] == tempArray[i]) dict[i-1,i-1]++;
//         else dict[i,1] = tempArray[i];
//         {
            
//         }
//     }
// }


int matrixRows = 5;
int matrixColumns = 5;
int matrixMinValue = 1;
int matrixMaxValue = 10;

int[,] firstMatrix = CreateMatrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue );
PrintMatrix(firstMatrix);
Console.WriteLine(String.Empty);

int[] firstArray = NumberDictionary(firstMatrix);
PrintArray(firstArray);
Console.WriteLine(String.Empty);
Array.Sort(firstArray);
PrintArray(firstArray);
Console.WriteLine(String.Empty);
Dictionary(firstArray);


int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return matrix;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void Dictionary (int[] array)
{
    int number = array[0];
    int count = 1;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else 
        {
            Console.WriteLine($"{number} -> {count}");
            number = array[i];
            count = 1;
        }    
    }
    Console.WriteLine($"{number} -> {count}");
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine($"]", 4);
    }
}

int[] NumberDictionary (int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix[i,j];
            index++;
        }
    }
    return array;
}


