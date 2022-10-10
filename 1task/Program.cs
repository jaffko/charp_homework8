// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray(int[] array)
{
    int i = 0;
    int temp = 0;
    while (i <= array.Length)
    {
        for (int j = array.Length-1; j > i; j--)
        {
            if (array[j] > array[j-1])
            {
                temp = array[j];
                array[j] = array[j-1];
                array[j-1] = temp;
            }
        }
        i++;
    }
}

void SortByRows(int[,] array)
{
    int[] temp = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[j] = array[i,j];
        }
        SortArray(temp);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = temp[j];
        }
    }
}

System.Console.WriteLine("Введите размерность массива m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
SortByRows(array);
PrintArray(array);

