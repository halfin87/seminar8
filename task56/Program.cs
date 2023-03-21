//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void GetAverageValue(int[,] array)
{
    int index = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        // Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    // string line = string.Empty;
    // for (int j = 0; j < array.GetLength(1); j++)
    // {
    //     line += array[index, j] + " ";
    // }
    Console.WriteLine($"Строка с минимальной суммой элементов равна {index + 1}. ");
}

int[,] myarray = GetRandomarray(3, 4);
Printmatrix(myarray);
GetAverageValue(myarray);