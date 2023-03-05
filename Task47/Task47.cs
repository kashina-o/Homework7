// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double Input(string msg)
{
  bool flag = false;
  double value = 0;
  while (!flag)
  {
    Console.Write(msg + " ");
    flag = double.TryParse(Console.ReadLine(), out value);
  }
  return value;
}

double[,] CreateArray(int a, int b)
{
    double[,] matrix = new double[a, b];
    return matrix;
}

void FillRandomNumbers(double[,] matrix, double min, double max)
{
int row = matrix.GetLength(0);
int columns = matrix.GetLength(1);
for (int i = 0; i < row; i++)
    {
    for (int j = 0; j < columns; j++)
        {
        Random random = new Random();
        matrix[i,j] = Math.Round((max + 1 - min) * random.NextDouble() + min, 2);
        }
    }    
}

string Print(double[,] matrix)
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

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double min = Input("Введите минимальное значение диапозона: ");
double max = Input("Введите максимальное значение диапозона: ");
double[,] matrix = CreateArray(m,n);
FillRandomNumbers(matrix, min, max);
Console.WriteLine(Print(matrix));