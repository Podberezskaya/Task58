// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите размер первой матрицы: ");
int [ ] size = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
int[,] firstMartrix = new int[size[0], size[1]];
Console.WriteLine("Введите размер второй матрицы: ");
int [ ] size1 = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
int[,] secomdMartrix = new int[size[0], size[1]];
int[,] resultMatrix = new int[size[0], size[1]];
InputMatrix(firstMartrix);
Console.WriteLine("Первая матрица:");
PrintMatrix(firstMartrix);
InputMatrix(secomdMartrix);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secomdMartrix);
Release(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine("Результирующая матрица:");
PrintMatrix(resultMatrix);

void Release(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < firstMartrix.GetLength(0); i++)
  {
    for (int j = 0; j < secomdMartrix.GetLength(0); j++)
    {
    resultMatrix [i,j] = firstMartrix[i,j] * secomdMartrix[i,j];
    }
  }
}
void InputMatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,11);
    }
  }
}
void PrintMatrix (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i,j]}\t");
    }
    Console.WriteLine();
  }
}
