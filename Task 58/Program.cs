using System;
using static System.Console;
Clear();

Write("Enter the number of rows of the 1 array: ");
int rows1 = Convert.ToInt32(ReadLine());
Write("Enter the number of columns of the 1 array: ");
int columns1 = Convert.ToInt32(ReadLine());
Write("Enter the number of rows of the 2 array: ");
int rows2 = Convert.ToInt32(ReadLine());
Write("Enter the number of columns of the 2 array: ");
int columns2 = Convert.ToInt32(ReadLine());

int[,] A = GetArray(rows1, columns1, 0, 10);
int[,] B = GetArray(rows2, columns2, 0, 10);
PrintArray(A);
WriteLine();
PrintArray(B);
WriteLine();
PrintArray(GetMultiplicationMatrix(A, B));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}