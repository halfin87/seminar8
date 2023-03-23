// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

int[,,] GetRandomArray(int rows, int columns, int width)
{
  int[,,] array = new int[rows, columns, width];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[i, j, z] = Random.Shared.Next(1, 10);
      }
    }
  }
  return array;
}

void PrintArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int z = 0; z < array.GetLength(1); z++)
      {
        Console.Write($"{array[i, j, z]} ({i} {j} {z}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

int[,,] myarray = GetRandomArray(3, 2, 2);
PrintArray(myarray);