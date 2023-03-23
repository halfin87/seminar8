//  Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

int[,] GetRandomarray(int rows, int columns)
{
  int[,] array = new int[rows, columns];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Random.Shared.Next(1, 10);
    }

  }
  return array;
}

void Printmatrix(int[,] array)
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

void GetNewArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = i + 1; j < array.GetLength(1); j++)
    {
      for (int z = 0; z < array.GetLength(1) - 1; z++)
      {
        if (array[i, z] > array[i, z + 1])
        {
          int temp = 0;
          temp = array[i, z];
          array[i, z] = array[i,z+1];
          array[i,z+1] = temp;
        }
      }
    }
  }
}

int[,] myarray = GetRandomarray(3, 4);
Printmatrix(myarray);
Console.WriteLine();
GetNewArray(myarray);
Printmatrix(myarray);
