// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 11);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] firstArray, int[,] secondArray)
{
    int[,] result = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                result[i,j] = result[i,j] + firstArray[i,k] * secondArray[k,j];
            }
        }
    }
    return result;
}

System.Console.WriteLine("Введите размерность первого массива m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] firstArray = FillArray(m, n);
System.Console.WriteLine("Введите размерность второго массива m и n");
m = Convert.ToInt32(Console.ReadLine());
n = Convert.ToInt32(Console.ReadLine());
int[,] secondArray = FillArray(m, n);
System.Console.WriteLine();
PrintArray(firstArray);
System.Console.WriteLine();
PrintArray(secondArray);
if (firstArray.GetLength(0) != secondArray.GetLength(1)
    || firstArray.GetLength(1) != secondArray.GetLength(0)) System.Console.WriteLine("Матрицы не согласованны");
else PrintArray(MatrixMultiplication(firstArray,secondArray));
