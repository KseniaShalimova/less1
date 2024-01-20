﻿int[,] matrix = CreateMatrix(3,4);
showMatrix(matrix);
foreach (int e in matrix)
{
    if (IsInteresting(e)==true)
    {
        Console.WriteLine(e);
    }
}



int[,] CreateMatrix(int rowCounts, int columCounts)
{
    int[,] matrix = new int[rowCounts, columCounts];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value>0)
    {
        sum = sum + value%10;
        value = value/10;
    }
    return sum;
}



bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits%2==0)
    {
        return true;
    }
    return false;
}


void showMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}