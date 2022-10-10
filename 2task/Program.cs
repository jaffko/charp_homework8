// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int LowestRowBySum(int[,] array)
{
    int[] rowSums = new int[array.GetLength(0)];
    int[] minRow = { 0, 0 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) rowSums[i] = rowSums[i] + array[i, j];
        if (i == 0) minRow[0] = rowSums[i];
        else if (rowSums[i] < minRow[0])
        {
            minRow[0] = rowSums[i];
            minRow[1] = i;
        }
    }
    return minRow[1] + 1;
}

System.Console.WriteLine("Введите размерность массива m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
System.Console.WriteLine($"Строка с наименьшей суммой {LowestRowBySum(array)}");