//Заполните спирально массив

Console.Write("Введите размерность матрицы: ");
int n = int.Parse(Console.ReadLine()!);
int[,] sMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sMatrix.GetLength(0) * sMatrix.GetLength(1))
{
  sMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

PrintArray(sMatrix);