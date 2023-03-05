// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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

void MatrixElement(int[,] matrix,int rowIndex,int columnIndex)
{
    if (rowIndex < matrix.GetLength(0) 
        && columnIndex < matrix.GetLength(1)) 
    Console.WriteLine($"Значение элемента массива: {matrix[rowIndex, columnIndex]}");
    else Console.WriteLine("Такого числа в массиве нет");
}

int a = Input("Введите количество строк: ");
int b = Input("Введите количество столбцов: ");
int min = Input("Введите минимальное значение диапозона: ");
int max = Input("Введите максимальное значение диапозона: ");
int[,] matrix = CreateArray(a, b);
FillRandomNumbers(matrix,min,max);
Console.WriteLine(Print(matrix));
int row = Input("Введите индекс строки: ");
int column = Input("Введите индекс столбца: ");
MatrixElement(matrix, row, column);
