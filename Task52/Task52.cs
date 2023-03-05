// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int Input(string msg)
{
  bool flag = false;
  int value = 0;
  while (!flag)
  {
    Console.Write(msg + " ");
    flag = int.TryParse(Console.ReadLine(), out value);
  }
  return value;
}

int[,] CreateArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    return matrix;
}

void FillRandomNumbers(int[,] matrix, int min, int max)
{
int row = matrix.GetLength(0);
int columns = matrix.GetLength(1);
for (int i = 0; i < row; i++)
    {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = new Random().Next(min, max);
    }
    }
}

string Print(int[,] matrix)
{
string result = string.Empty;
int row = matrix.GetLength(0);
int columns = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        result += $"{matrix[i, j],5} ";
      }
      result += "\n";
    }
return result;
}

void AvgColumnOfMatrix(int[,] matrix)
{
for (int column = 0; column < matrix.GetLength(1); column++)
{
    double sumElementsOfColumn = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        sumElementsOfColumn += matrix[row, column];
    }
    Console.Write($"{ Math.Round(sumElementsOfColumn / matrix.GetLength(0), 2)} ");
}
}
 
int a = Input("Введите количество строк: ");
int b = Input("Введите количество столбцов: ");
int min = Input("Введите минимальное значение диапозона: ");
int max = Input("Введите максимальное значение диапозона: ");
int[,] matrix = CreateArray(a, b);
FillRandomNumbers(matrix,min,max);
Console.WriteLine(Print(matrix));
Console.Write("Среднее арифметическое каждого столбца: ");
AvgColumnOfMatrix(matrix);
