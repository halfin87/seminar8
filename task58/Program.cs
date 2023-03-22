// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49

int[,] GetRandomArray(int rows, int columns)
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



int[,] GetThirdArray(int[,] array1, int[,] array2)
{
  int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
  for (int i = 0; i < array3.GetLength(0); i++)
  {
    for (int j = 0; j < array3.GetLength(1); j++)
    {
      array3[i, j] += array1[i, j] * array2[i, j];
    }
  }
  return array3;
}

int[,] myarray = GetRandomArray(3, 4);
PrintArray(myarray);
Console.WriteLine();
int[,] secondarray = GetRandomArray(3, 4);
PrintArray(secondarray);
Console.WriteLine();
PrintArray(GetThirdArray(myarray, secondarray));
