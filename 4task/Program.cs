// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Fill3DArray()
{
    int[,,] result = new int[2,2,2];
    int[] dictionary = new int[100];
    int number = new Random().Next(10,100);
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int z = 0; z < 2; z++)
            {
                while (dictionary[number] != 0) number = new Random().Next(10,100);
                result[i,j,z] = number;
                dictionary[number]++;
            }
        }
    }
   return result;
}

void Print3DArray(int[,,] array)
{
    for (int z = 0; z < 2; z++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write(array[i,j,z] + $"({i},{j},{z}) ");
            }
            Console.WriteLine();
        }
    }
}

Print3DArray(Fill3DArray());