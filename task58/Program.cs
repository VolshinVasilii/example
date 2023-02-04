int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}

void MatrixProduct(int[,] firstMatrix, int[,] secondMatrix, int[,] productMatrix)
{
    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            productMatrix[i, j] = sum;
        }
    }
}

int[,] firstArray = CreateMatrixRndInt(3, 3, 1, 3);
PrintMatrix(firstArray);
Console.WriteLine();
int[,] secondArray = CreateMatrixRndInt(2, 3, 1, 3);
PrintMatrix(secondArray);
Console.WriteLine();
int row = firstArray.GetLength(0);
int col = secondArray.GetLength(1);
if (row == col)
{
    int[,] result = new int[row, col];
    MatrixProduct(firstArray, secondArray, result);
    Console.WriteLine("Результат умножения матриц:");
    PrintMatrix(result);
}
else Console.WriteLine("Число строк первой матрицы не соответствует числу столбцов второй матрицы - перемножение невозможно");

